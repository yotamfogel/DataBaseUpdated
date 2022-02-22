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
    public class ProductArr : ArrayList
    {
          public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Product_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Product curProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curProduct = new Product(dataRow);
                this.Add(curProduct);
            }
        }
        public Product GetProductWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Product maxProduct = new Product();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).ID > maxProduct.ID)
                    maxProduct = this[i] as Product;

            return maxProduct;
        }
        public bool IsContains(string ProductName)
        {
            //בדיקה האם יש ישוב עם אותו שם

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Name == ProductName)
                    return true;
            return false;
        }

        public ProductArr Filter(string name, Company company, Category category)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {

                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                if (

                //סינון לפי שם המוצר

                product.Name.StartsWith(name)

                //סינון לפי החברה
                && (company == null || company.ID == -1 || product.Company.Id == company.ID)
                //סינון לפי קטגוריה
                && (category == null || category.ID == -1 || product.Category.ID == category.ID)
                )

                    //ה מוצר ענה לדרישות החיפוש - הוספה שלו לאוסף המוחזר

                    productArr.Add(product);
            }
            return productArr;
        }
    }
}
