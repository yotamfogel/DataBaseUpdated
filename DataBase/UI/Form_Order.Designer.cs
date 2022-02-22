
namespace DataBase.UI
{
    partial class Form_Order
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete = new System.Windows.Forms.Button();
            this.cityId = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.Product_Listbox = new System.Windows.Forms.ListBox();
            this.cityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Order_Listbox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.delete);
            this.tabPage1.Controls.Add(this.Order_Listbox);
            this.tabPage1.Controls.Add(this.Clear);
            this.tabPage1.Controls.Add(this.Filter);
            this.tabPage1.Controls.Add(this.submit);
            this.tabPage1.Controls.Add(this.cityId);
            this.tabPage1.Controls.Add(this.Product_Listbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkRed;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(91, 330);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(66, 35);
            this.delete.TabIndex = 34;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // cityId
            // 
            this.cityId.AutoSize = true;
            this.cityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityId.Location = new System.Drawing.Point(390, 260);
            this.cityId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityId.Name = "cityId";
            this.cityId.Size = new System.Drawing.Size(18, 20);
            this.cityId.TabIndex = 33;
            this.cityId.Text = "0";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(427, 330);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 35);
            this.Clear.TabIndex = 32;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(284, 330);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(124, 35);
            this.submit.TabIndex = 31;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // Product_Listbox
            // 
            this.Product_Listbox.FormattingEnabled = true;
            this.Product_Listbox.Location = new System.Drawing.Point(354, 20);
            this.Product_Listbox.Margin = new System.Windows.Forms.Padding(2);
            this.Product_Listbox.Name = "Product_Listbox";
            this.Product_Listbox.Size = new System.Drawing.Size(154, 238);
            this.Product_Listbox.TabIndex = 30;
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(129, 65);
            this.cityName.Margin = new System.Windows.Forms.Padding(2);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(142, 20);
            this.cityName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(360, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Company";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(45, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Category";
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.label5);
            this.Filter.Controls.Add(this.textBox1);
            this.Filter.Controls.Add(this.textBox2);
            this.Filter.Controls.Add(this.label3);
            this.Filter.Controls.Add(this.label4);
            this.Filter.Controls.Add(this.label1);
            this.Filter.Controls.Add(this.cityName);
            this.Filter.Location = new System.Drawing.Point(48, 20);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(293, 163);
            this.Filter.TabIndex = 37;
            this.Filter.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 97);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Filter";
            // 
            // Order_Listbox
            // 
            this.Order_Listbox.FormattingEnabled = true;
            this.Order_Listbox.Location = new System.Drawing.Point(521, 20);
            this.Order_Listbox.Margin = new System.Windows.Forms.Padding(2);
            this.Order_Listbox.Name = "Order_Listbox";
            this.Order_Listbox.Size = new System.Drawing.Size(154, 238);
            this.Order_Listbox.TabIndex = 38;
            // 
            // Form_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Products";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox Order_Listbox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label cityId;
        private System.Windows.Forms.ListBox Product_Listbox;
        private System.Windows.Forms.Label label2;
    }
}