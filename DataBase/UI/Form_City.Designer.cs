
namespace DataBase.UI
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(425, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(152, 74);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(188, 22);
            this.cityName.TabIndex = 2;
            this.cityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityName_KeyPress);
            // 
            // City_Listbox
            // 
            this.City_Listbox.FormattingEnabled = true;
            this.City_Listbox.ItemHeight = 16;
            this.City_Listbox.Location = new System.Drawing.Point(430, 40);
            this.City_Listbox.Name = "City_Listbox";
            this.City_Listbox.Size = new System.Drawing.Size(204, 180);
            this.City_Listbox.TabIndex = 4;
            this.City_Listbox.DoubleClick += new System.EventHandler(this.City_Listbox_DoubleClick);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(236, 378);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(165, 43);
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
            this.Clear.Location = new System.Drawing.Point(408, 378);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(108, 43);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // cityId
            // 
            this.cityId.AutoSize = true;
            this.cityId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cityId.Location = new System.Drawing.Point(462, 232);
            this.cityId.Name = "cityId";
            this.cityId.Size = new System.Drawing.Size(23, 25);
            this.cityId.TabIndex = 25;
            this.cityId.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.cityId);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.City_Listbox);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
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
    }
}