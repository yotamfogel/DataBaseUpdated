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
    public partial class Form_Category : Form
    {
        public Category SelectedCategory { get => Category_Listbox.SelectedItem as Category; }
        public Form_Category(Category Category = null)
        {
            InitializeComponent();

            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (Category != null && Category.ID <= 0)
                Category = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CategoryArrToForm(Category);
            CategoryToForm(Category);

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

        private void CategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!IsEngLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.KeyChar = char.MinValue;
            }
        }
        private bool CheckForm()
        {
            bool isOk = true;

            if (CategoryName.Text == "")
            {
                CategoryName.BackColor = Color.Red;
                isOk = false;
            }
            return isOk;
        }

        private void ReturnToWhite()
        {
            if (CategoryName.BackColor == Color.Red)
            {

                CategoryName.BackColor = Color.White;
            }

        }
        private void CategoryToForm(Category Category)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס
            if (Category != null)
            {
                CategoryID.Text = Category.ID.ToString();
                CategoryName.Text = Category.Name.ToString();
            }
            else
            {
                CategoryID.Text = 0.ToString();
                CategoryName.Text = "";
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
                Category Category = FormToCategory();
                if (Category.ID == 0)
                {
                    CategoryArr oldCategoryArr = new CategoryArr();
                    oldCategoryArr.Fill();
                    if (!oldCategoryArr.IsContains(Category.Name))
                    {
                        if (Category.Insert())
                        {
                            MessageBox.Show("Category Added");
                            CategoryArr CategoryArr = new CategoryArr();
                            CategoryArr.Fill();
                            Category = CategoryArr.GetCategoryWithMaxId();
                            CategoryArrToForm(Category);
                            //עדכון תיבת הרשימה
                        }
                        else
                            MessageBox.Show("Error, Category not added");

                    }
                    else
                        MessageBox.Show("Category already exists!");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (Category.Update())
                    {
                        MessageBox.Show("Your form has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CategoryArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }

                CategoryArrToForm();
                ReturnToWhite();


            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CategoryToForm(null);
        }

        private Category FormToCategory()
        {
            Category a = new Category();
            a.ID = int.Parse(CategoryID.Text);
            a.Name = CategoryName.Text;
            return a;
        }
        private void CategoryArrToForm(Category curCategory = null)
        {

            CategoryArr CategoryArr = new CategoryArr();
            CategoryArr.Fill();
            Category_Listbox.DataSource = CategoryArr;
            Category_Listbox.ValueMember = "Id";
            Category_Listbox.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCategory != null)
                Category_Listbox.SelectedValue = curCategory.ID;
        }

        private void Category_Listbox_DoubleClick(object sender, EventArgs e)
        {
            CategoryToForm(Category_Listbox.SelectedItem as Category);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (CategoryID.Text == "0")
                MessageBox.Show("You must select a Category");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Category Category = FormToCategory();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(Category))
                        MessageBox.Show("You can’t delete a Category that is related to a client");
                    else
                    if (Category.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CategoryToForm(null);
                        CategoryArrToForm();
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
