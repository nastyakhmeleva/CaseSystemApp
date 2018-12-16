namespace CaseSystemApp
{
    partial class OpenDB
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(237, 107);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 29);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveDB
            // 
            this.SaveDB.Location = new System.Drawing.Point(74, 107);
            this.SaveDB.Name = "SaveDB";
            this.SaveDB.Size = new System.Drawing.Size(95, 29);
            this.SaveDB.TabIndex = 15;
            this.SaveDB.Text = "Сохранить";
            this.SaveDB.UseVisualStyleBackColor = true;
            this.SaveDB.Click += new System.EventHandler(this.SaveDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название базы данных";
            // 
            // DBName
            // 
            this.DBName.Location = new System.Drawing.Point(193, 57);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(139, 20);
            this.DBName.TabIndex = 17;
            // 
            // OpenDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 185);
            this.Controls.Add(this.DBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveDB);
            this.Controls.Add(this.CancelButton);
            this.Name = "OpenDB";
            this.Text = "Изменить базу данных";
            this.Load += new System.EventHandler(this.OpenDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DBName;
    }
}