
namespace DataBase.UI
{
    partial class Form_Company
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
            this.delete = new System.Windows.Forms.Button();
            this.CompanyID = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.company_Listbox = new System.Windows.Forms.ListBox();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkRed;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(106, 373);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 43);
            this.delete.TabIndex = 34;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // CompanyID
            // 
            this.CompanyID.AutoSize = true;
            this.CompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CompanyID.Location = new System.Drawing.Point(528, 226);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(23, 25);
            this.CompanyID.TabIndex = 33;
            this.CompanyID.Text = "0";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(475, 373);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(108, 43);
            this.Clear.TabIndex = 32;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(303, 373);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(165, 43);
            this.submit.TabIndex = 31;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // company_Listbox
            // 
            this.company_Listbox.FormattingEnabled = true;
            this.company_Listbox.ItemHeight = 16;
            this.company_Listbox.Location = new System.Drawing.Point(496, 34);
            this.company_Listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.company_Listbox.Name = "company_Listbox";
            this.company_Listbox.Size = new System.Drawing.Size(204, 180);
            this.company_Listbox.TabIndex = 30;
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(219, 69);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(188, 22);
            this.CompanyName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(492, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Company Name";
            // 
            // Form_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.CompanyID);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.company_Listbox);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Company";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label CompanyID;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListBox company_Listbox;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}