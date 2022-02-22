
namespace DataBase
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.addCompany = new System.Windows.Forms.Button();
            this.companyCombobox = new System.Windows.Forms.ComboBox();
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.companyBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.submit = new System.Windows.Forms.Button();
            this.label0 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addCategory = new System.Windows.Forms.Button();
            this.filterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Company:";
            // 
            // addCompany
            // 
            this.addCompany.Location = new System.Drawing.Point(660, 146);
            this.addCompany.Margin = new System.Windows.Forms.Padding(4);
            this.addCompany.Name = "addCompany";
            this.addCompany.Size = new System.Drawing.Size(31, 25);
            this.addCompany.TabIndex = 60;
            this.addCompany.Text = "+";
            this.addCompany.UseVisualStyleBackColor = true;
            // 
            // companyCombobox
            // 
            this.companyCombobox.FormattingEnabled = true;
            this.companyCombobox.Location = new System.Drawing.Point(499, 146);
            this.companyCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.companyCombobox.Name = "companyCombobox";
            this.companyCombobox.Size = new System.Drawing.Size(153, 24);
            this.companyCombobox.TabIndex = 59;
            this.companyCombobox.Text = "Choose a company";
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.idBox);
            this.filterBox.Controls.Add(this.filter);
            this.filterBox.Controls.Add(this.label14);
            this.filterBox.Controls.Add(this.companyBox);
            this.filterBox.Controls.Add(this.label13);
            this.filterBox.Controls.Add(this.categoryBox);
            this.filterBox.Controls.Add(this.label12);
            this.filterBox.Location = new System.Drawing.Point(21, 33);
            this.filterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterBox.Name = "filterBox";
            this.filterBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterBox.Size = new System.Drawing.Size(247, 196);
            this.filterBox.TabIndex = 58;
            this.filterBox.TabStop = false;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(115, 65);
            this.idBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idBox.MaxLength = 10;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(123, 22);
            this.idBox.TabIndex = 26;
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.Location = new System.Drawing.Point(93, 23);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(74, 29);
            this.filter.TabIndex = 25;
            this.filter.Text = "Filter";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(12, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Category";
            // 
            // companyBox
            // 
            this.companyBox.Location = new System.Drawing.Point(115, 98);
            this.companyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyBox.Name = "companyBox";
            this.companyBox.Size = new System.Drawing.Size(123, 22);
            this.companyBox.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.Location = new System.Drawing.Point(13, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 24);
            this.label13.TabIndex = 30;
            this.label13.Text = "Company";
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(115, 135);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(123, 22);
            this.categoryBox.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(35, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "ID";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(547, 233);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(144, 43);
            this.Clear.TabIndex = 56;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(370, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 55;
            this.label11.Text = "ID:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idLabel.Location = new System.Drawing.Point(629, 59);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(23, 25);
            this.idLabel.TabIndex = 54;
            this.idLabel.Text = "0";
            // 
            // listBox_Products
            // 
            this.listBox_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.ItemHeight = 25;
            this.listBox_Products.Location = new System.Drawing.Point(21, 248);
            this.listBox_Products.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(247, 254);
            this.listBox_Products.TabIndex = 53;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(375, 233);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(165, 43);
            this.submit.TabIndex = 48;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // label0
            // 
            this.label0.BackColor = System.Drawing.SystemColors.Menu;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label0.Location = new System.Drawing.Point(370, 98);
            this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(123, 28);
            this.label0.TabIndex = 37;
            this.label0.Text = "Name:";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(499, 102);
            this.Name.Margin = new System.Windows.Forms.Padding(4);
            this.Name.MaxLength = 50;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(153, 22);
            this.Name.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(758, 540);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "*";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(499, 187);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(153, 24);
            this.categoryComboBox.TabIndex = 62;
            this.categoryComboBox.Text = "Choose a category";
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(660, 187);
            this.addCategory.Margin = new System.Windows.Forms.Padding(4);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(31, 25);
            this.addCategory.TabIndex = 64;
            this.addCategory.Text = "+";
            this.addCategory.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 552);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addCompany);
            this.Controls.Add(this.companyCombobox);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.listBox_Products);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductForm";
            this.Text = "6";
            this.filterBox.ResumeLayout(false);
            this.filterBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCompany;
        private System.Windows.Forms.ComboBox companyCombobox;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label filter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox companyBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addCategory;
    }
}