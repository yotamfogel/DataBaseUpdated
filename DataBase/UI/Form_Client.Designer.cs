
namespace DataBase
{
    partial class ClientForm
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.phoneNumBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.cityCombobox = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.filterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(133, 37);
            this.firstName.MaxLength = 50;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(207, 20);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            this.firstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstName_KeyPress);
            // 
            // label0
            // 
            this.label0.BackColor = System.Drawing.SystemColors.Menu;
            this.label0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label0.Location = new System.Drawing.Point(6, 37);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(92, 23);
            this.label0.TabIndex = 1;
            this.label0.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(133, 75);
            this.lastName.MaxLength = 50;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(207, 20);
            this.lastName.TabIndex = 5;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            this.lastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastName_KeyPress);
            // 
            // phoneNum
            // 
            this.phoneNum.Location = new System.Drawing.Point(133, 114);
            this.phoneNum.MaxLength = 10;
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(206, 20);
            this.phoneNum.TabIndex = 6;
            this.phoneNum.TextChanged += new System.EventHandler(this.phoneNum_TextChanged);
            this.phoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNum_KeyPress);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(132, 152);
            this.dateOfBirth.MaxDate = new System.DateTime(5000, 12, 31, 0, 0, 0, 0);
            this.dateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(207, 20);
            this.dateOfBirth.TabIndex = 9;
            this.dateOfBirth.Value = new System.DateTime(2021, 11, 2, 0, 0, 0, 0);
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(133, 192);
            this.zipCode.MaxLength = 10;
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(207, 20);
            this.zipCode.TabIndex = 11;
            this.zipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipCode_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Menu;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Zip Code:";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(133, 239);
            this.country.MaxLength = 50;
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(207, 20);
            this.country.TabIndex = 13;
            this.country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.country_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Menu;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Country:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(133, 286);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(124, 35);
            this.submit.TabIndex = 15;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(96, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(124, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(96, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(22, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 29);
            this.label10.TabIndex = 19;
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 20;
            this.listBox_Clients.Location = new System.Drawing.Point(362, 37);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(157, 204);
            this.listBox_Clients.TabIndex = 20;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idLabel.Location = new System.Drawing.Point(403, 252);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 20);
            this.idLabel.TabIndex = 21;
            this.idLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(370, 251);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "ID:";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(262, 286);
            this.Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 35);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(444, 249);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 32);
            this.deleteButton.TabIndex = 24;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // filter
            // 
            this.filter.AutoSize = true;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.Location = new System.Drawing.Point(70, 19);
            this.filter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(57, 24);
            this.filter.TabIndex = 25;
            this.filter.Text = "Filter";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(86, 53);
            this.idBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idBox.MaxLength = 10;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(93, 20);
            this.idBox.TabIndex = 26;
            this.idBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idBox_KeyPress);
            this.idBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idBox_KeyUp);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(86, 80);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(93, 20);
            this.lastNameBox.TabIndex = 27;
            this.lastNameBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lastNameBox_KeyUp);
            // 
            // phoneNumBox
            // 
            this.phoneNumBox.Location = new System.Drawing.Point(86, 110);
            this.phoneNumBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNumBox.Name = "phoneNumBox";
            this.phoneNumBox.Size = new System.Drawing.Size(93, 20);
            this.phoneNumBox.TabIndex = 28;
            this.phoneNumBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.phoneNumBox_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(26, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.Location = new System.Drawing.Point(4, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 30;
            this.label13.Text = "Last Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(9, 110);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Phone #";
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.idBox);
            this.filterBox.Controls.Add(this.filter);
            this.filterBox.Controls.Add(this.label14);
            this.filterBox.Controls.Add(this.lastNameBox);
            this.filterBox.Controls.Add(this.label13);
            this.filterBox.Controls.Add(this.phoneNumBox);
            this.filterBox.Controls.Add(this.label12);
            this.filterBox.Location = new System.Drawing.Point(524, 37);
            this.filterBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterBox.Name = "filterBox";
            this.filterBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterBox.Size = new System.Drawing.Size(185, 159);
            this.filterBox.TabIndex = 32;
            this.filterBox.TabStop = false;
            // 
            // cityCombobox
            // 
            this.cityCombobox.FormattingEnabled = true;
            this.cityCombobox.Location = new System.Drawing.Point(571, 234);
            this.cityCombobox.Name = "cityCombobox";
            this.cityCombobox.Size = new System.Drawing.Size(121, 21);
            this.cityCombobox.TabIndex = 33;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(598, 261);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(52, 20);
            this.save.TabIndex = 34;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(718, 329);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cityCombobox);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.filterBox.ResumeLayout(false);
            this.filterBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox phoneNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label filter;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.ComboBox cityCombobox;
        private System.Windows.Forms.Button save;
    }
}

