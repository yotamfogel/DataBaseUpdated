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
        static public bool Insert(string firstName, string lastName, string phoneNum, DateTime dateOfBirth, string zipCode, string country, int CityID)
        {
            string sql = $"INSERT INTO Table_Client ([FirstName],[LastName],[PhoneNum],[DateOfBirth],[ZipCode],[Country],[City]) VALUES ('{firstName}', '{lastName}', '{phoneNum}', '{dateOfBirth}', '{zipCode}', '{country}', {CityID})";
            return Dal.ExecuteSql(sql); 
        }

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

            //הגדרת משתנה קשר הגומלין
            DataRelation dataRelation = null;

            //הוספת טבלת הישובים לאוסף הטבלאות
            City_Dal.FillDataSet(dataSet);

            //עמדות הקשר בטבלת האב והבן + שם קשר הגומלין
            dataRelation = new DataRelation("ClientCity", dataSet.Tables["Table_City"].Columns["ID"], dataSet.Tables["Table_Client"].Columns["City"]);

            //הוספת קשר הגומלין לאוסף הטבלאות
            dataSet.Relations.Add(dataRelation);
        }

        public static bool Update(int ID, string firstName, string lastName, string phoneNum, DateTime dateOfBirth, string zipCode, string country, int CityID)
        {
            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = '{firstName}'"
            + $",[LastName] = '{lastName}'"
            + $",[PhoneNum] = '{phoneNum}'"  
            + $",[DateOfBirth] = '{dateOfBirth}'"
            + $",[ZipCode] = '{zipCode}'"
            + $",[Country] = '{country}'"
            + $",[City] = {CityID}"
            + $" WHERE [ID] = {ID}";

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
    

}