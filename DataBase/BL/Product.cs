using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBase.BL
{
        public class Product
    {

        private int m_ID;
        private string m_Name;
        private Category m_Category;
        private Company m_Company;

        public int ID { get => m_ID; set => m_ID = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public Company Company { get => m_Company; set => m_Company= value; }
        public Category Category { get => m_Category; set => m_Category = value; }
        public Product(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["ID"];
            m_Name = (string)dataRow["Name"];
        }
        public Product(int id, string name)
        {
            this.m_ID = id;
            this.m_Name = name;
        }

        public Product()
        {
        }

        public bool Update()
        {
            return DAL.Product_Dal.Update(m_ID, m_Name);
        }
        public bool Insert()
        {
            return DAL.Product_Dal.Insert(m_ID, m_Name);
        }
        public bool Delete()
        {
            return DAL.Product_Dal.Delete(m_ID);
        }
        public override string ToString()
        { return $"{m_Name}"; }
    }
}
