using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.BL;
using System.Data;

namespace DataBase.DAL
{
    class Order_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Order"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלה הנוכחית - בתנאי שהטבלה לא נמצאת כבר באוסף

            if (!dataSet.Tables.Contains("Table_Order"))
                Dal.FillDataSet(dataSet, "Table_Order", "[Name]");
        }

        public static bool Update(int id, Client client, DateTime date, string note, string fullname, string cardnumber, string cvv, DateTime expdate)
        {
            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Order SET"

            + $" [Client] = '{client}'"
            + $" [Date] = '{date}'"
            + $" [Note] = '{note}'"
            + $" [FullName] = '{fullname}'"
            + $" [CardNumber] = '{cardnumber}'"
            + $" [CVV] = '{cvv}'"
            + $" [ExpDate] = '{expdate}'"
            + $" WHERE [Id] = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את הלקוח ממסד הנתונים
            string str = $"DELETE FROM Table_Order WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        
        public static bool Insert(int id, Client client, DateTime date, string note, string fullname, string cardnumber, string cvv, DateTime expdate)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Order"
            + " VALUES "
            + "("
            + $"'{id}'"
            + $"'{client}'"
            + $"'{date}'"
            + $"'{note}'"
            + $"'{fullname}'"
            + $"'{cardnumber}'"
            + $"'{cvv}'"
            + $"'{expdate}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}