using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.UI;
using DataBase.BL;
using DataBase.DAL;
using System.Windows.Forms;

namespace DataBase.UI
{
    public partial class Form_Order : Form
    {
        public Form_Order()
        {
            InitializeComponent();
        }

        //ORDER DETAILS
        private void textBoxID_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (textBoxID.Text != "")
                id = int.Parse(textBoxID.Text);

            //מייצרים אוסף של כלל הלקוחות

            OrderArr OrderArr = new OrderArr();
            OrderArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            OrderArr = OrderArr.Filter(id, dateTimeFrom.Value, dateTimeTo.Value,
            (Client)clientBox.SelectedItem);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            orderBox.DataSource = OrderArr;
        } //filter

        private void dateTimeFrom_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (textBoxID.Text != "")
                id = int.Parse(textBoxID.Text);

            //מייצרים אוסף של כלל הלקוחות

            OrderArr OrderArr = new OrderArr();
            OrderArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            OrderArr = OrderArr.Filter(id, dateTimeFrom.Value, dateTimeTo.Value,
            (Client)clientBox.SelectedItem);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            orderBox.DataSource = OrderArr;
        }

        private void dateTimeTo_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (textBoxID.Text != "")
                id = int.Parse(textBoxID.Text);

            //מייצרים אוסף של כלל הלקוחות

            OrderArr OrderArr = new OrderArr();
            OrderArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            OrderArr = OrderArr.Filter(id, dateTimeFrom.Value, dateTimeTo.Value,
            (Client)clientBox.SelectedItem);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            orderBox.DataSource = OrderArr;
        }

        private void clientBox_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (textBoxID.Text != "")
                id = int.Parse(textBoxID.Text);

            //מייצרים אוסף של כלל הלקוחות

            OrderArr OrderArr = new OrderArr();
            OrderArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            OrderArr = OrderArr.Filter(id, dateTimeFrom.Value, dateTimeTo.Value,
            (Client)clientBox.SelectedItem);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            orderBox.DataSource = OrderArr;
        } //end filter

        private void OrderToForm(Order order)
        { 

            //ממירה את המידע בטנ "מ לקוח לטופס
            if (order != null)
            {
                idLabel.Text = order.ID.ToString();
                dateTimePicker1.Value = order.Date;
                richTextBox1.Text = order.Note;
                clientLabel.Text = order.Client.FirstName + " " + order.Client.LastName;
                cardNumber.Text = order.CardNumber;
                fullName.Text = order.FullName;
                cvv.Text = order.CVV;
                expDate.Value = order.ExpDate;
            }
            else
            {
                idLabel.Text = order.ID.ToString();
                dateTimePicker1.Value = DateTime.Today;
                richTextBox1.Text = "";
                clientLabel.Text = "";
                cardNumber.Text = "";
                fullName.Text = "";
                cvv.Text = "";
                expDate.Value = DateTime.Today;
            }
        }
        private void orderBox_DoubleClick(object sender, EventArgs e)
        {
            OrderToForm(orderBox.SelectedItem as Order);
        } //order listbox to all labels
        private Order FormToOrder()
        {
            Order a = new BL.Order();
            a.ID = int.Parse(idLabel.Text);
            a.Date = this.dateTimePicker1.Value;
            a.Note= this.richTextBox1.Text;
            a.FullName = this.fullName.Text;
            a.CardNumber = this.cardNumber.Text;
            a.CVV = this.cvv.Text;
            a.ExpDate = this.expDate.Value;
            if (this.richTextBox1 != null)
                a.Note = this.richTextBox1.Text;
            return a;
        }
        private bool CheckForm()
        {
            bool isOk = true;

            if (dateTimePicker1.Value != DateTime.Today)
            {
                dateTimePicker1.BackColor = Color.Red;
                isOk = false;
            }
            if (fullName.Text == null)
            {
                fullName.BackColor = Color.Red;
                isOk = false;
            }
            if (cardNumber.Text == null)
            {
                cardNumber.BackColor = Color.Red;
                isOk = false;
            }
            if (cvv.Text == null)
            {
                cvv.BackColor = Color.Red;
                isOk = false;
            }
            if (expDate.Value != DateTime.Today)
            {
                fullName.BackColor = Color.Red;
                isOk = false;
            }
            return isOk;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Order order = FormToOrder();
                if (order.ID == 0)
                {

                    if (order.Insert())
                    {
                        MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Fill all the mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //עדכון לקוח קיים

                    if (order.Update())
                    {
                        MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OrderArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                OrderArrToForm();
                ReturnToWhite();


            }
        } //save
        private void OrderArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            orderBox.DataSource = orderArr;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1) //if im in first tab, clear only first tab
                OrderToForm(null);
            if (tabControl1.SelectedTab == tabPage2) //if im in second tab, clear only second tab
                ClientToForm(null)
        } //clear
        private void ReturnToWhite()
        {
            dateTimePicker1.CalendarTitleBackColor = Color.White;
            richTextBox1.BackColor = Color.White;
            fullName.BackColor = Color.White;
            cardNumber.BackColor = Color.White;
            cvv.BackColor = Color.White;
            expDate.CalendarTitleBackColor = Color.White;
        } //return all fields to white
        //END ORDER DETAILS

        //CLIENT DETAILS
        private void ClientToForm(Client client)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס
            if (client != null)
            {
                label_last.Text = client.LastName;
                label_first.Text = client.FirstName;
                label_phone.Text = client.PhoneNum;
            }
            else
            {
                label_last.Text = client.LastName;
                label_first.Text = client.FirstName;
                label_phone.Text = client.PhoneNum;
            }
        }
        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (textBoxID.Text != "")
                id = int.Parse(textBoxID.Text);

            //מייצרים אוסף של כלל הלקוחות

            OrderArr OrderArr = new OrderArr();
            OrderArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            OrderArr = OrderArr.Filter(id, dateTimeFrom.Value, dateTimeTo.Value,
            (Client)clientBox.SelectedItem);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            orderBox.DataSource = OrderArr;
        } //filter

        private void textbox_Phone_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (textBoxID.Text != "")
                id = int.Parse(textBoxID.Text);

            //מייצרים אוסף של כלל הלקוחות

            OrderArr OrderArr = new OrderArr();
            OrderArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            OrderArr = OrderArr.Filter(id, dateTimeFrom.Value, dateTimeTo.Value,
            (Client)clientBox.SelectedItem);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            orderBox.DataSource = OrderArr;
        } //end filter

        private void listbox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listbox_Clients.SelectedItem as Client);
        } //client listbox to client labels

        private void clientBox_Click(object sender, EventArgs e)
        {
            //IM HERE I NEED TO FIND OUT HOW TO INSERT CLIENTS INTO THE COMBOBOX DROPDOWN
        }
    }
}
