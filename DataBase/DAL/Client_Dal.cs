using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace DataBase.DAL
{
    class Client_Dal
    {

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[LastName],[FirstName]");
            DataRelation dataRelation = null;
            City_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "ClientCity" , dataSet.Tables["Table_City"].Columns["ID"]
            , dataSet.Tables["Table_Client"].Columns["City"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }

        public static bool Insert(string firstName, string lastName, string phoneNum, DateTime dateOfBirth, string zipCode, string country)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[ZipCode],[DateOfBirth],[Country],[PhoneNum]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{firstName}',N'{lastName}',{zipCode},{dateOfBirth},{country},{phoneNum}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Update(int Id, string firstName, string lastName, string phoneNum, DateTime dateOfBirth, string zipCode, string country)
        {
            //מעדכנת את הלקוח במסד הנתונים
            dateOfBirth.ToString("yyyy-MM-dd");
            string str = "UPDATE Table_Client SET"

            + $" [FirstName] = '{firstName}'"
            + $",[LastName] = '{lastName}'"
            + $",[PhoneNum] = '{phoneNum}'"
            + $",[DateTime] = {dateOfBirth}"
            + $",[ZipCode] = '{zipCode}'"
            + $",[Country] = '{country}'"
            + $" WHERE [Id] = {Id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {
            //מוחקת את הלקוח ממסד הנתונים
            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }

    public class ClientArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Client_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            BL.Client curClient;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curClient = new BL.Client(dataRow);
                this.Add(curClient);
            }
        }
    }
}