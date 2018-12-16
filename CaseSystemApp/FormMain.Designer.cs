namespace CaseSystemApp
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EntityList = new System.Windows.Forms.ComboBox();
            this.AddEntity = new System.Windows.Forms.Button();
            this.ChangeEntity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FormList = new System.Windows.Forms.ComboBox();
            this.ChangeForm = new System.Windows.Forms.Button();
            this.AddForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangeQuestion = new System.Windows.Forms.Button();
            this.QuestionList = new System.Windows.Forms.ComboBox();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.ChangeReport = new System.Windows.Forms.Button();
            this.ReportList = new System.Windows.Forms.ComboBox();
            this.AddReport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeServer = new System.Windows.Forms.Button();
            this.AddServer = new System.Windows.Forms.Button();
            this.ServerList = new System.Windows.Forms.ComboBox();
            this.ChangeBD = new System.Windows.Forms.Button();
            this.AddDB = new System.Windows.Forms.Button();
            this.DBList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Сущности";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(12, 9);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(44, 13);
            this.ServerLabel.TabIndex = 18;
            this.ServerLabel.Text = "Сервер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "База данных";
            // 
            // EntityList
            // 
            this.EntityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntityList.FormattingEnabled = true;
            this.EntityList.Location = new System.Drawing.Point(113, 140);
            this.EntityList.Name = "EntityList";
            this.EntityList.Size = new System.Drawing.Size(178, 21);
            this.EntityList.TabIndex = 20;
            // 
            // AddEntity
            // 
            this.AddEntity.Location = new System.Drawing.Point(113, 167);
            this.AddEntity.Name = "AddEntity";
            this.AddEntity.Size = new System.Drawing.Size(81, 24);
            this.AddEntity.TabIndex = 21;
            this.AddEntity.Text = "Добавить";
            this.AddEntity.UseVisualStyleBackColor = true;
            this.AddEntity.Click += new System.EventHandler(this.AddEntity_Click);
            // 
            // ChangeEntity
            // 
            this.ChangeEntity.Location = new System.Drawing.Point(200, 167);
            this.ChangeEntity.Name = "ChangeEntity";
            this.ChangeEntity.Size = new System.Drawing.Size(91, 24);
            this.ChangeEntity.TabIndex = 29;
            this.ChangeEntity.Text = "Просмотреть";
            this.ChangeEntity.UseVisualStyleBackColor = true;
            this.ChangeEntity.Click += new System.EventHandler(this.OpenEntity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Формы";
            // 
            // FormList
            // 
            this.FormList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormList.FormattingEnabled = true;
            this.FormList.Location = new System.Drawing.Point(113, 267);
            this.FormList.Name = "FormList";
            this.FormList.Size = new System.Drawing.Size(178, 21);
            this.FormList.TabIndex = 31;
            // 
            // ChangeForm
            // 
            this.ChangeForm.Location = new System.Drawing.Point(200, 294);
            this.ChangeForm.Name = "ChangeForm";
            this.ChangeForm.Size = new System.Drawing.Size(91, 24);
            this.ChangeForm.TabIndex = 33;
            this.ChangeForm.Text = "Просмотреть";
            this.ChangeForm.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AddForm.Location = new System.Drawing.Point(113, 294);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(81, 24);
            this.AddForm.TabIndex = 32;
            this.AddForm.Text = "Добавить";
            this.AddForm.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Запросы";
            // 
            // ChangeQuestion
            // 
            this.ChangeQuestion.Location = new System.Drawing.Point(200, 231);
            this.ChangeQuestion.Name = "ChangeQuestion";
            this.ChangeQuestion.Size = new System.Drawing.Size(91, 24);
            this.ChangeQuestion.TabIndex = 37;
            this.ChangeQuestion.Text = "Просмотреть";
            this.ChangeQuestion.UseVisualStyleBackColor = true;
            // 
            // QuestionList
            // 
            this.QuestionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuestionList.FormattingEnabled = true;
            this.QuestionList.Location = new System.Drawing.Point(113, 204);
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(178, 21);
            this.QuestionList.TabIndex = 36;
            // 
            // AddQuestion
            // 
            this.AddQuestion.Location = new System.Drawing.Point(113, 231);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(81, 24);
            this.AddQuestion.TabIndex = 35;
            this.AddQuestion.Text = "Добавить";
            this.AddQuestion.UseVisualStyleBackColor = true;
            // 
            // ChangeReport
            // 
            this.ChangeReport.Location = new System.Drawing.Point(200, 356);
            this.ChangeReport.Name = "ChangeReport";
            this.ChangeReport.Size = new System.Drawing.Size(91, 24);
            this.ChangeReport.TabIndex = 41;
            this.ChangeReport.Text = "Просмотреть";
            this.ChangeReport.UseVisualStyleBackColor = true;
            // 
            // ReportList
            // 
            this.ReportList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportList.FormattingEnabled = true;
            this.ReportList.Location = new System.Drawing.Point(113, 329);
            this.ReportList.Name = "ReportList";
            this.ReportList.Size = new System.Drawing.Size(178, 21);
            this.ReportList.TabIndex = 40;
            // 
            // AddReport
            // 
            this.AddReport.Location = new System.Drawing.Point(113, 356);
            this.AddReport.Name = "AddReport";
            this.AddReport.Size = new System.Drawing.Size(81, 24);
            this.AddReport.TabIndex = 39;
            this.AddReport.Text = "Добавить";
            this.AddReport.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Отчеты";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ChangeServer
            // 
            this.ChangeServer.Location = new System.Drawing.Point(210, 33);
            this.ChangeServer.Name = "ChangeServer";
            this.ChangeServer.Size = new System.Drawing.Size(81, 24);
            this.ChangeServer.TabIndex = 44;
            this.ChangeServer.Text = "Изменить";
            this.ChangeServer.UseVisualStyleBackColor = true;
            this.ChangeServer.Click += new System.EventHandler(this.OpenServer_Click);
            // 
            // AddServer
            // 
            this.AddServer.Location = new System.Drawing.Point(113, 33);
            this.AddServer.Name = "AddServer";
            this.AddServer.Size = new System.Drawing.Size(81, 24);
            this.AddServer.TabIndex = 43;
            this.AddServer.Text = "Добавить";
            this.AddServer.UseVisualStyleBackColor = true;
            this.AddServer.Click += new System.EventHandler(this.AddServer_Click);
            // 
            // ServerList
            // 
            this.ServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerList.FormattingEnabled = true;
            this.ServerList.Location = new System.Drawing.Point(113, 6);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(178, 21);
            this.ServerList.TabIndex = 42;
            this.ServerList.SelectedIndexChanged += new System.EventHandler(this.ServerList_SelectedIndexChanged);
            // 
            // ChangeBD
            // 
            this.ChangeBD.Location = new System.Drawing.Point(210, 100);
            this.ChangeBD.Name = "ChangeBD";
            this.ChangeBD.Size = new System.Drawing.Size(81, 24);
            this.ChangeBD.TabIndex = 47;
            this.ChangeBD.Text = "Изменить";
            this.ChangeBD.UseVisualStyleBackColor = true;
            this.ChangeBD.Click += new System.EventHandler(this.OpenBD_Click);
            // 
            // AddDB
            // 
            this.AddDB.Location = new System.Drawing.Point(113, 100);
            this.AddDB.Name = "AddDB";
            this.AddDB.Size = new System.Drawing.Size(81, 24);
            this.AddDB.TabIndex = 46;
            this.AddDB.Text = "Добавить";
            this.AddDB.UseVisualStyleBackColor = true;
            this.AddDB.Click += new System.EventHandler(this.AddDB_Click);
            // 
            // DBList
            // 
            this.DBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DBList.FormattingEnabled = true;
            this.DBList.Location = new System.Drawing.Point(113, 73);
            this.DBList.Name = "DBList";
            this.DBList.Size = new System.Drawing.Size(178, 21);
            this.DBList.TabIndex = 45;
            this.DBList.SelectedIndexChanged += new System.EventHandler(this.DBList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 43);
            this.button1.TabIndex = 48;
            this.button1.Text = "Просмотреть созданную базу данных";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChangeBD);
            this.Controls.Add(this.AddDB);
            this.Controls.Add(this.DBList);
            this.Controls.Add(this.ChangeServer);
            this.Controls.Add(this.AddServer);
            this.Controls.Add(this.ServerList);
            this.Controls.Add(this.ChangeReport);
            this.Controls.Add(this.ReportList);
            this.Controls.Add(this.AddReport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChangeQuestion);
            this.Controls.Add(this.QuestionList);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChangeForm);
            this.Controls.Add(this.AddForm);
            this.Controls.Add(this.FormList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeEntity);
            this.Controls.Add(this.AddEntity);
            this.Controls.Add(this.EntityList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "CaseSystem";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EntityList;
        private System.Windows.Forms.Button AddEntity;
        private System.Windows.Forms.Button ChangeEntity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FormList;
        private System.Windows.Forms.Button ChangeForm;
        private System.Windows.Forms.Button AddForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ChangeQuestion;
        private System.Windows.Forms.ComboBox QuestionList;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.Button ChangeReport;
        private System.Windows.Forms.ComboBox ReportList;
        private System.Windows.Forms.Button AddReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ChangeServer;
        private System.Windows.Forms.Button AddServer;
        private System.Windows.Forms.ComboBox ServerList;
        private System.Windows.Forms.Button ChangeBD;
        private System.Windows.Forms.Button AddDB;
        private System.Windows.Forms.ComboBox DBList;
        private System.Windows.Forms.Button button1;
    }
}

