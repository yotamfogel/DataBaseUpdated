using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isChanged = false;
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
                ReturnToWhite();
                MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BL.Client client = FormToClient();
                client.Insert();
            }
        }

        private bool CheckForm()
        {
            if ((!isChanged) || (phoneNum.Text.Length != 7))
            {
                phoneNum.BackColor = Color.Red;
                return false;
            }

            if (firstName.Text.Length < 2)
            {
                firstName.BackColor = Color.Red;
                return false;
            }

            if (lastName.Text.Length < 2)
            {
                lastName.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            isChanged = true;
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
            a.m_FirstName = this.firstName.Text;
            a.m_LastName = this.lastName.Text;
            a.m_phoneNum = this.comboBox1.Text + this.phoneNum.Text;
            if (zipCode.Text != null)
                a.m_zipCode = this.zipCode.Text;
            if (dateOfBirth.Text != null)
                a.m_dateOfBirth = this.dateOfBirth.Value;
            if (country.Text != null)
                a.m_country = this.country.Text;
            return a;
        }
        private void zipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.KeyChar = char.MinValue;
            if ((zipCode.Text.Length > 6) && (e.KeyChar != (char)Keys.Back))
                e.KeyChar = char.MinValue;
        }

        private void label0_Click(object sender, EventArgs e)
        {

        }
    }
}
