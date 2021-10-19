﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBase.DAL
{
    class Client_Dal
    {
        static public void Insert(string firstName, string lastName, string phoneNum, DateTime dateOfBirth, string zipCode, string country)
        {
            string sql = $"INSERT INTO Table_Client ([FirstName],[LastName],[PhoneNum],[DateOfBirth],[ZipCode],[Country]) VALUES ('{firstName}', '{lastName}', '{phoneNum}', '{dateOfBirth}', '{zipCode}', '{country}')";
            Dal.ExecuteSql(sql); 
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
            //בהמשך יהיו כאן הוראות נוספות הקשורות לקשרי גומלין...

        }

        public static bool Update(int Id, string firstName, string lastName, string phoneNum, DateTime dateOfBirth, string zipCode, string country)
        {
            //מעדכנת את הלקוח במסד הנתונים

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
    }
    

}
