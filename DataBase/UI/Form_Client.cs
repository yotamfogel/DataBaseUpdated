using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase.BL;
using DataBase.UI;



namespace DataBase
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            ClientArrToForm();
            CityArrToForm();
        }
        private bool IsEngLetter(char a)
        {
            if (char.IsLetter(a))
            {
                if ((a >= 'a') && (a <= 'z') || (a >= 'A') && (a <= 'Z'))
                {
                    return true;
                }
            }
            return false;

        }
        private void firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!IsEngLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.KeyChar = char.MinValue;
            }
        }

        private void phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.KeyChar = char.MinValue;
        }

        private void lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!IsEngLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.KeyChar = char.MinValue;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
                if (!CheckForm())
                {
                    MessageBox.Show("Fill all the mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Client client = FormToClient();
                    if (client.ID == 0)
                    {

                        if (client.Insert())
                        {
                            MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Fill all the mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        //עדכון לקוח קיים

                        if (client.Update())
                        {
                            MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClientArrToForm();
                        }
                        else
                            MessageBox.Show("Error updating");
                    }
                    ClientArrToForm();
                    ReturnToWhite();

                
                }
        }

        private bool CheckForm()
        {
            bool isOk = true;

            if (firstName.Text.Length < 2)
            {
                firstName.BackColor = Color.Red;
                isOk = false;
            }

            if (lastName.Text.Length < 2)
            {
                lastName.BackColor = Color.Red;
                isOk = false;
            }

            if (phoneNum.Text.Length != 10)
            {
                phoneNum.BackColor = Color.Red;
                isOk = false;
            }

            if (!isCity)
            {
                cityCombobox.ForeColor = Color.Red;
                isOk = false;
            }
            return isOk;
        }

        private void ReturnToWhite()
        {
            TextBox[] a = new TextBox[3];
            a[0] = firstName;
            a[1] = lastName;
            a[2] = phoneNum;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].BackColor == Color.Red)
                {
                    a[i].BackColor = Color.White;
                }
            }


        }

        private void country_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!IsEngLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back)) && (e.KeyChar != (char)Keys.Space))
                e.KeyChar = char.MinValue;
        }

        private BL.Client FormToClient()
        {
            BL.Client a = new BL.Client();
            a.ID = int.Parse(idLabel.Text);
            a.FirstName = this.firstName.Text;
            a.LastName = this.lastName.Text;
            a.PhoneNum = this.phoneNum.Text;
            a.City = cityCombobox.SelectedItem as City;
            if (zipCode.Text != null)
                a.ZipCode = this.zipCode.Text;
            if (dateOfBirth.Text != null)
                a.DateOfBirth = this.dateOfBirth.Value;
            if (country.Text != null)
                a.Country = this.country.Text;
            return a;
        }
        public void CityArrToForm(City curCity = null)
        {
            CityArr cityArr = new CityArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            City cityDefault = new City();
            cityDefault.ID = -1;
            cityDefault.Name = "Choose a city ";

//הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            cityArr.Add(cityDefault);
            cityArr.Fill();
            cityCombobox.DataSource = cityArr;
            cityCombobox.ValueMember = "Id";
            cityCombobox.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב, הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCity != null)
                cityCombobox.SelectedValue = curCity.ID;
        }
        private void zipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.KeyChar = char.MinValue;
            if ((zipCode.Text.Length > 6) && (e.KeyChar != (char)Keys.Back))
                e.KeyChar = char.MinValue;
        }

        private void ClientArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }

        private void ClientToForm(Client client)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס
            if (client != null)
            {
                idLabel.Text = client.ID.ToString();
                firstName.Text = client.FirstName;
                lastName.Text = client.LastName;
                zipCode.Text = client.ZipCode.ToString();
                phoneNum.Text = client.PhoneNum.ToString();
                dateOfBirth.Value = client.DateOfBirth;
                country.Text = client.Country;
                cityCombobox.SelectedValue = client.City.ID;
            }
            else
            {
                idLabel.Text = "0";
                firstName.Text = "";
                lastName.Text = "";
                zipCode.Text = "";
                phoneNum.Text = "";
                dateOfBirth.Value = DateTime.Today;
                country.Text = "";
                cityCombobox.SelectedItem = null;
            }
        }


        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as Client);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClientToForm(null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Client client = FormToClient();
            if (client.ID == 0)
                MessageBox.Show("Please select a client");
            else
            {
                if (MessageBox.Show("Are you sure you want to delete client #" + client.ID + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (client.Delete())
                    {
                        MessageBox.Show("Client #" + client.ID + " has been successfully deleted.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClientToForm(null);
                    }
                    else
                        ClientToForm(null);
                    ClientArrToForm();
                }
            }
        }
     

        private void phoneNum_TextChanged(object sender, EventArgs e)
        {
            phoneNum.BackColor = Color.White;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            lastName.BackColor = Color.White;
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            firstName.BackColor = Color.White;
        }

        private void idBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.KeyChar = char.MinValue;
        }

        private void idBox_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (idBox.Text != "")
                id = int.Parse(idBox.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id, lastNameBox.Text,
            phoneNumBox.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;
        }
        private void lastNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (idBox.Text != "")
                id = int.Parse(idBox.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id, lastNameBox.Text,
            phoneNumBox.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;

        }

        private void phoneNumBox_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (idBox.Text != "")
                id = int.Parse(idBox.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id, lastNameBox.Text,
            phoneNumBox.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            CityForm formCity = new CityForm(cityCombobox.SelectedItem as City);
            formCity.ShowDialog();
            CityArrToForm(formCity.SelectedCity);
        }
        private bool isCity = false;
        private void cityCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            isCity = true;
        }
    }
}

