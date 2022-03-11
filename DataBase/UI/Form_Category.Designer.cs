
namespace DataBase.UI
{
    partial class Form_Category
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
            this.CategoryID = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.Category_Listbox = new System.Windows.Forms.ListBox();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkRed;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(127, 373);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 43);
            this.delete.TabIndex = 42;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // CategoryID
            // 
            this.CategoryID.AutoSize = true;
            this.CategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CategoryID.Location = new System.Drawing.Point(549, 226);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(23, 25);
            this.CategoryID.TabIndex = 41;
            this.CategoryID.Text = "0";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(496, 373);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(108, 43);
            this.Clear.TabIndex = 40;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(324, 373);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(165, 43);
            this.submit.TabIndex = 39;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // Category_Listbox
            // 
            this.Category_Listbox.FormattingEnabled = true;
            this.Category_Listbox.ItemHeight = 16;
            this.Category_Listbox.Location = new System.Drawing.Point(517, 34);
            this.Category_Listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Category_Listbox.Name = "Category_Listbox";
            this.Category_Listbox.Size = new System.Drawing.Size(204, 180);
            this.Category_Listbox.TabIndex = 38;
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(240, 69);
            this.CategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(188, 22);
            this.CategoryName.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(513, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(80, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Category Name";
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.CategoryID);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Category_Listbox);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Category";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label CategoryID;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListBox Category_Listbox;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}