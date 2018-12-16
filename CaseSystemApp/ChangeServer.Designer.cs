namespace CaseSystemApp
{
    partial class ChangeServer
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
            this.SaveServer = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveServer
            // 
            this.SaveServer.Location = new System.Drawing.Point(92, 32);
            this.SaveServer.Name = "SaveServer";
            this.SaveServer.Size = new System.Drawing.Size(95, 29);
            this.SaveServer.TabIndex = 15;
            this.SaveServer.Text = "Изменить";
            this.SaveServer.UseVisualStyleBackColor = true;
            this.SaveServer.Click += new System.EventHandler(this.SaveServer_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(193, 32);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 29);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 13);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Имя сервера";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(92, 6);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(196, 20);
            this.ServerName.TabIndex = 18;
            // 
            // OpenServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 74);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveServer);
            this.Name = "OpenServer";
            this.Text = "Изменить сервер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveServer;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ServerName;
    }
}