using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using DataBase.DAL; //מתאים לשכבת הדאל שלי

namespace DataBase.BL
{
    public class OrderArr : ArrayList
    {
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Order_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Order curOrder;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curOrder = new Order(dataRow);
                this.Add(curOrder);
            }
        }
        public Order GetOrderWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Order maxOrder = new Order();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).ID > maxOrder.ID)
                    maxOrder = this[i] as Order;

            return maxOrder;
        }

        public OrderArr Filter(int id, DateTime FromDate, DateTime ToDate, Client client)
        {
            OrderArr orderArr = new OrderArr();
            Order order;
            for (int i = 0; i < this.Count; i++)
            {
                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                order = (this[i] as Order);
                if
                (
                // מזהה 0 – כלומר, לא נבחר מזהה בסינון
                (id == 0 || order.ID == id) && (client == null || client.ID == -1 || order.Client.ID == client.ID) && (order.Date >= FromDate && order.Date <= ToDate)
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                    orderArr.Add(order);
            }
            return orderArr;
        }
    }
}
