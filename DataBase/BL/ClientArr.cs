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
        public class ClientArr : ArrayList
        {
            public void Fill()
            {

                //להביא מה-DAL טבלה מלאה בכל הלקוחות

                DataTable dataTable = Client_Dal.GetDataTable();

                //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
                //להעביר כל שורה בטבלה ללקוח

                DataRow dataRow;
                Client curClient;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataRow = dataTable.Rows[i];
                    curClient = new Client(dataRow);
                    this.Add(curClient);
                }
            }
      
        }


}
