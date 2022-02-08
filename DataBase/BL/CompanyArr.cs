using System;
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
    public class CompanyArr : ArrayList
    {
          public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Company_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Company curCompany;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCompany = new Company(dataRow);
                this.Add(curCompany);
            }
        }
        public Company GetCompanyWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Company maxCompany = new Company();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Company).ID > maxCompany.ID)
                    maxCompany = this[i] as Company;

            return maxCompany;
        }
        public bool IsContains(string CompanyName)
        {
            //בדיקה האם יש ישוב עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Company).Name == CompanyName)
                    return true;
            return false;
        }
    }
}
