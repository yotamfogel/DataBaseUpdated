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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

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

                    if (city.Insert())
                    {
                        MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Fill all the mandatory fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CityArr oldCityArr = new CityArr();
                oldCityArr.Fill();
                if (!oldCityArr.IsContains(city.Name))
                {
                    if (city.Insert())
                    {
                        MessageBox.Show("City Added");

                        //עדכון תיבת הרשימה

                        CityArrToForm();
                    }
                    else
                        MessageBox.Show("Error, City not added");

                }
                else
                    MessageBox.Show("City already exists!");  
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
        private void CityArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CityArr cityArr = new CityArr();
            cityArr.Fill();
            City_Listbox.DataSource = cityArr;
        }

        private void City_Listbox_DoubleClick(object sender, EventArgs e)
        {
            CityToForm(City_Listbox.SelectedItem as City);
        }

    }
}
               