﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using DataBase.DAL; //מתאים לשכבת הדאל שלי
using DataBase.BL;

namespace DataBase.BL
{
    public class CityArr : ArrayList
    {
          public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = City_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            City curCity;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCity = new City(dataRow);
                this.Add(curCity);
            }
        }   
        public bool IsContains(string cityName)
        {
            //בדיקה האם יש ישוב עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as City).Name == cityName)
                    return true;
            return false;
        }
    }
}
