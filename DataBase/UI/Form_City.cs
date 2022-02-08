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

namespace DataBase.UI
{
    public partial class CityForm : Form
    {
        public City SelectedCity { get => City_Listbox.SelectedItem as City; }
        public CityForm(City city = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (city != null && city.ID <= 0)
                city = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CityArrToForm(city);
            CityToForm(city);

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

        private void cityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!IsEngLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.KeyChar = char.MinValue;
            }
        }
        private bool CheckForm()
        {
            bool isOk = true;

            if (cityName.Text == "")
            {
                cityName.BackColor = Color.Red;
                isOk = false;
            }
            return isOk;
        }

        private void ReturnToWhite()
        {
            if (cityName.BackColor == Color.Red)
            {

                cityName.BackColor = Color.White;
            }

        }
        private void CityToForm(City city)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס
            if (city != null)
            {
                cityId.Text = city.ID.ToString();
                cityName.Text = city.Name.ToString();
            }
            else
            {
                cityId.Text = 0.ToString();
                cityName.Text = "";
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
                City city = FormToCity();
                if (city.ID == 0)
                {
                    CityArr oldCityArr = new CityArr();
                    oldCityArr.Fill();
                    if (!oldCityArr.IsContains(city.Name))
                    {
                        if (city.Insert())
                        {
                            MessageBox.Show("City Added");
                            CityArr cityArr = new CityArr();
                            cityArr.Fill();
                            city = cityArr.GetCityWithMaxId();
                            CityArrToForm(city);
                            //עדכון תיבת הרשימה
                        }
                        else
                            MessageBox.Show("Error, City not added");

                    }
                    else
                        MessageBox.Show("City already exists!");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (city.Update())
                    {
                        MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CityArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                
                CityArrToForm();
                ReturnToWhite();


            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CityToForm(null);
        }

        private City FormToCity()
        {
            City a = new City();
            a.ID = int.Parse(cityId.Text);
            a.Name = cityName.Text;
            return a;
        }
        private void CityArrToForm(City curCity = null)
        {

            CityArr cityArr = new CityArr();
            cityArr.Fill();
            City_Listbox.DataSource = cityArr;
            City_Listbox.ValueMember = "Id";
            City_Listbox.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCity != null)
                City_Listbox.SelectedValue = curCity.ID;
        }

        private void City_Listbox_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(City_Listbox.SelectedItem as City);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (cityId.Text == "0")
                MessageBox.Show("You must select a city");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    City city = FormToCity();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(city))
                        MessageBox.Show("You can’t delete a city that is related to a client");
                    else
                    if (city.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CityToForm(null);
                        CityArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }
    }
}
               