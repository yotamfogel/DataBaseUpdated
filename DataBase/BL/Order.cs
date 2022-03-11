using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataBase.BL
{
    public class Order
    {

        private int m_ID;
        private Client m_Client;
        private DateTime m_Date;
        private string m_Note;
        private string m_FullName;
        private string m_CardNumber;
        private string m_CVV;
        private DateTime m_ExpDate;

        public int ID { get => m_ID; set => m_ID = value; }
        public Client Client { get => m_Client; set => m_Client = value; }
        public DateTime Date { get => m_Date; set => m_Date = value; }
        public string Note { get => m_Note; set => m_Note = value; }
        public string FullName { get => m_FullName; set => m_FullName = value; }
        public string CardNumber { get => m_CardNumber; set => m_CardNumber = value; }
        public string CVV { get => m_CVV; set => m_CVV = value; }

        public DateTime ExpDate { get => m_ExpDate; set => m_ExpDate = value; }
        public Order(DataRow dataRow)
        {
            //מייצרת לקוח מתוך שורת לקוח

            m_ID = (int)dataRow["ID"];
            m_Client = (Client)dataRow["Client"];
            m_Date = (DateTime)dataRow["Date"];
            m_Note = (string)dataRow["Note"];
            m_FullName = (string)dataRow["FullName"];
            m_CardNumber = (string)dataRow["CardNumber"];
            m_CVV = (string)dataRow["CVV"];
            m_ExpDate = (DateTime)dataRow["ExpDate"];
            
        }
        public Order(int id, Client client, DateTime date, string note, string fullname, string cardnumber, string cvv, DateTime expdate)
        { 
            this.m_ID = id;
            this.m_Client = client;
            this.m_Date = date;
            this.m_Note = note;
            this.FullName = fullname;
            this.CardNumber = cardnumber;
            this.CVV = cvv;
            this.ExpDate = expdate;
        }

        public Order()
        {
        }

        public bool Update()
        {
            return DAL.Order_Dal.Update(m_ID, m_Client, m_Date, m_Note, m_FullName, m_CardNumber, m_CVV, m_ExpDate);
        }
        public bool Insert()
        {
            return DAL.Order_Dal.Insert(m_ID, m_Client, m_Date, m_Note, m_FullName, m_CardNumber, m_CVV, m_ExpDate);
        }
        public bool Delete()
        {
            return DAL.Order_Dal.Delete(m_ID);
        }
        public override string ToString()
        { return $"{m_ID}" +$"{m_Client}" +$"{m_Date}" +$"{m_Note}" +$"{m_FullName}" +$"{m_CardNumber}"
            +$"{m_CVV}" +$"{m_ExpDate}"; }
    }
}
