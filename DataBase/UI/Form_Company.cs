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
    public partial class Form_Company : Form
    {
        public Company SelectedCompany { get => company_Listbox.SelectedItem as Company; }
        public Form_Company(Company Company = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (Company != null && Company.ID <= 0)
                Company = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CompanyArrToForm(Company);
            CompanyToForm(Company);

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

        private void CompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!IsEngLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.KeyChar = char.MinValue;
            }
        }
        private bool CheckForm()
        {
            bool isOk = true;

            if (CompanyName.Text == "")
            {
                CompanyName.BackColor = Color.Red;
                isOk = false;
            }
            return isOk;
        }

        private void ReturnToWhite()
        {
            if (CompanyName.BackColor == Color.Red)
            {

                CompanyName.BackColor = Color.White;
            }

        }
        private void CompanyToForm(Company Company)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס
            if (Company != null)
            {
                CompanyID.Text = Company.ID.ToString();
                CompanyName.Text = Company.Name.ToString();
            }
            else
            {
                CompanyID.Text = 0.ToString();
                CompanyName.Text = "";
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
                Company Company = FormToCompany();
                if (Company.ID == 0)
                {
                    CompanyArr oldCompanyArr = new CompanyArr();
                    oldCompanyArr.Fill();
                    if (!oldCompanyArr.IsContains(Company.Name))
                    {
                        if (Company.Insert())
                        {
                            MessageBox.Show("Company Added");
                            CompanyArr CompanyArr = new CompanyArr();
                            CompanyArr.Fill();
                            Company = CompanyArr.GetCompanyWithMaxId();
                            CompanyArrToForm(Company);
                            //עדכון תיבת הרשימה
                        }
                        else
                            MessageBox.Show("Error, Company not added");

                    }
                    else
                        MessageBox.Show("Company already exists!");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (Company.Update())
                    {
                        MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CompanyArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }

                CompanyArrToForm();
                ReturnToWhite();


            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CompanyToForm(null);
        }

        private Company FormToCompany()
        {
            Company a = new Company();
            a.ID = int.Parse(CompanyID.Text);
            a.Name = CompanyName.Text;
            return a;
        }
        private void CompanyArrToForm(Company curCompany = null)
        {

            CompanyArr CompanyArr = new CompanyArr();
            CompanyArr.Fill();
            company_Listbox.DataSource = CompanyArr;
            company_Listbox.ValueMember = "Id";
            company_Listbox.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCompany != null)
                company_Listbox.SelectedValue = curCompany.ID;
        }

        private void Company_Listbox_DoubleClick(object sender, EventArgs e)
        {
            CompanyToForm(company_Listbox.SelectedItem as Company);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (CompanyID.Text == "0")
                MessageBox.Show("You must select a Company");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Company Company = FormToCompany();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(Company))
                        MessageBox.Show("You can’t delete a Company that is related to a client");
                    else
                    if (Company.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CompanyToForm(null);
                        CompanyArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }

        private void submit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
