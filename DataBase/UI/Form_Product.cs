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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            ProductArrToForm();
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
        private void Name_KeyPress(object sender, KeyPressEventArgs e)
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
                Product Product = FormToProduct();
                if (Product.ID == 0)
                {

                    if (Product.Insert())
                    {
                        MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Fill all the mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //עדכון לקוח קיים

                    if (Product.Update())
                    {
                        MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProductArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                ProductArrToForm();
                ReturnToWhite();


            }
        }

        private bool CheckForm()
        {
            bool isOk = true;

            if (Name.Text.Length < 2)
            {
                Name.BackColor = Color.Red;
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
                companyCombobox.ForeColor = Color.Red;
                isOk = false;
            }
            return isOk;
        }

        private void ReturnToWhite()
        {
            TextBox[] a = new TextBox[3];
            a[0] = Name;
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

        private BL.Product FormToProduct()
        {
            BL.Product a = new BL.Product();
            a.ID = int.Parse(idLabel.Text);
            a.FirstName = this.Name.Text;
            a.LastName = this.lastName.Text;
            a.PhoneNum = this.phoneNum.Text;
            a.City = companyCombobox.SelectedItem as City;
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
            companyCombobox.DataSource = cityArr;
            companyCombobox.ValueMember = "Id";
            companyCombobox.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב, הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCity != null)
                companyCombobox.SelectedValue = curCity.ID;
        }
        private void zipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.KeyChar = char.MinValue;
            if ((zipCode.Text.Length > 6) && (e.KeyChar != (char)Keys.Back))
                e.KeyChar = char.MinValue;
        }

        private void ProductArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ProductArr ProductArr = new ProductArr();
            ProductArr.Fill();
            listBox_Products.DataSource = ProductArr;
        }

        private void ProductToForm(Product Product)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס
            if (Product != null)
            {
                idLabel.Text = Product.ID.ToString();
                Name.Text = Product.FirstName;
                lastName.Text = Product.LastName;
                zipCode.Text = Product.ZipCode.ToString();
                phoneNum.Text = Product.PhoneNum.ToString();
                dateOfBirth.Value = Product.DateOfBirth;
                country.Text = Product.Country;
                companyCombobox.SelectedValue = Product.City.ID;
            }
            else
            {
                idLabel.Text = "0";
                Name.Text = "";
                lastName.Text = "";
                zipCode.Text = "";
                phoneNum.Text = "";
                dateOfBirth.Value = DateTime.Today;
                country.Text = "";
                companyCombobox.SelectedItem = null;
            }
        }


        private void listBox_Products_DoubleClick(object sender, EventArgs e)
        {
            ProductToForm(listBox_Products.SelectedItem as Product);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ProductToForm(null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Product Product = FormToProduct();
            if (Product.ID == 0)
                MessageBox.Show("Please select a Product");
            else
            {
                if (MessageBox.Show("Are you sure you want to delete Product #" + Product.ID + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    if (Product.Delete())
                    {
                        MessageBox.Show("Product #" + Product.ID + " has been successfully deleted.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProductToForm(null);
                    }
                    else
                        ProductToForm(null);
                    ProductArrToForm();
                }
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            Name.BackColor = Color.White;
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

            ProductArr ProductArr = new ProductArr();
            ProductArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            ProductArr = ProductArr.Filter(id, categoryBox.Text,
            companyBox.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Products.DataSource = ProductArr;
        }
        private void lastNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (idBox.Text != "")
                id = int.Parse(idBox.Text);

            //מייצרים אוסף של כלל הלקוחות

            ProductArr ProductArr = new ProductArr();
            ProductArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            ProductArr = ProductArr.Filter(id, companyBox.Text,
            categoryBox.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Products.DataSource = ProductArr;

        }

        private void phoneNumBox_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה
            if (idBox.Text != "")
                id = int.Parse(idBox.Text);

            //מייצרים אוסף של כלל הלקוחות

            ProductArr ProductArr = new ProductArr();
            ProductArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            ProductArr = ProductArr.Filter(id, companyBox.Text,
            categoryBox.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Products.DataSource = ProductArr;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            CityForm formCity = new CityForm(companyCombobox.SelectedItem as City);
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

