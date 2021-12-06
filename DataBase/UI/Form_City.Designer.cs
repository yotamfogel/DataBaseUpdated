
namespace DataBase.UI
{
    partial class CityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityName = new System.Windows.Forms.TextBox();
            this.City_Listbox = new System.Windows.Forms.ListBox();
            this.submit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.cityId = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(319, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(114, 60);
            this.cityName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(142, 20);
            this.cityName.TabIndex = 2;
            this.cityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityName_KeyPress);
            // 
            // City_Listbox
            // 
            this.City_Listbox.FormattingEnabled = true;
            this.City_Listbox.Location = new System.Drawing.Point(322, 32);
            this.City_Listbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.City_Listbox.Name = "City_Listbox";
            this.City_Listbox.Size = new System.Drawing.Size(154, 147);
            this.City_Listbox.TabIndex = 4;
            this.City_Listbox.DoubleClick += new System.EventHandler(this.City_Listbox_DoubleClick);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(177, 307);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(124, 35);
            this.submit.TabIndex = 16;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(306, 307);
            this.Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(81, 35);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // cityId
            // 
            this.cityId.AutoSize = true;
            this.cityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityId.Location = new System.Drawing.Point(346, 188);
            this.cityId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityId.Name = "cityId";
            this.cityId.Size = new System.Drawing.Size(18, 20);
            this.cityId.TabIndex = 25;
            this.cityId.Text = "0";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkRed;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(29, 307);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(66, 35);
            this.delete.TabIndex = 26;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 366);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cityId);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.City_Listbox);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CityForm";
            this.Text = "City";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.ListBox City_Listbox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label cityId;
        private System.Windows.Forms.Button delete;
    }
}