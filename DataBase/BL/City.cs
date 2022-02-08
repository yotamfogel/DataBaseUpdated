﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBase.BL
{
        public class City
    {

        private int m_ID;
        private string m_Name;

        public int ID { get => m_ID; set => m_ID = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public City(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["ID"];
            m_Name = (string)dataRow["Name"];
        }
        public City(int id, string name)
        {
            this.m_ID = id;
            this.m_Name = name;
        }

        public City()
        {
        }

        public bool Update()
        {
            return DAL.City_Dal.Update(m_ID, m_Name);
        }
        public bool Insert()
        {
            return DAL.City_Dal.Insert(m_ID, m_Name);
        }
        public bool Delete()
        {
            return DAL.City_Dal.Delete(m_ID);
        }
        public override string ToString()
        { return $"{m_Name}"; }
    }
}
