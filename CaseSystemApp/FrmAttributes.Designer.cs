namespace CaseSystemApp
{
    partial class FrmAttributes
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TypeAttribute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteAttribute = new System.Windows.Forms.Button();
            this.ChangeAttribute = new System.Windows.Forms.Button();
            this.AddAttribute = new System.Windows.Forms.Button();
            this.textBoxDescriptio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AtNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewATT = new System.Windows.Forms.DataGridView();
            this.NameAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewATT)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(435, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название сущности";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TypeAttribute);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TypeComboBox);
            this.groupBox1.Controls.Add(this.DeleteAttribute);
            this.groupBox1.Controls.Add(this.ChangeAttribute);
            this.groupBox1.Controls.Add(this.AddAttribute);
            this.groupBox1.Controls.Add(this.textBoxDescriptio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AtNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(454, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 190);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Атрибут";
            // 
            // TypeAttribute
            // 
            this.TypeAttribute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeAttribute.FormattingEnabled = true;
            this.TypeAttribute.Location = new System.Drawing.Point(72, 100);
            this.TypeAttribute.Name = "TypeAttribute";
            this.TypeAttribute.Size = new System.Drawing.Size(119, 21);
            this.TypeAttribute.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Тип атрибута";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(72, 73);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(119, 21);
            this.TypeComboBox.TabIndex = 11;
            // 
            // DeleteAttribute
            // 
            this.DeleteAttribute.Location = new System.Drawing.Point(87, 132);
            this.DeleteAttribute.Name = "DeleteAttribute";
            this.DeleteAttribute.Size = new System.Drawing.Size(75, 23);
            this.DeleteAttribute.TabIndex = 10;
            this.DeleteAttribute.Text = "Удалить";
            this.DeleteAttribute.UseVisualStyleBackColor = true;
            this.DeleteAttribute.Click += new System.EventHandler(this.DeleteAttribute_Click);
            // 
            // ChangeAttribute
            // 
            this.ChangeAttribute.Location = new System.Drawing.Point(6, 161);
            this.ChangeAttribute.Name = "ChangeAttribute";
            this.ChangeAttribute.Size = new System.Drawing.Size(75, 23);
            this.ChangeAttribute.TabIndex = 9;
            this.ChangeAttribute.Text = "Изменить";
            this.ChangeAttribute.UseVisualStyleBackColor = true;
            // 
            // AddAttribute
            // 
            this.AddAttribute.Location = new System.Drawing.Point(6, 132);
            this.AddAttribute.Name = "AddAttribute";
            this.AddAttribute.Size = new System.Drawing.Size(76, 23);
            this.AddAttribute.TabIndex = 8;
            this.AddAttribute.Text = "Добавить";
            this.AddAttribute.UseVisualStyleBackColor = true;
            this.AddAttribute.Click += new System.EventHandler(this.AddAttribute_Click);
            // 
            // textBoxDescriptio
            // 
            this.textBoxDescriptio.Location = new System.Drawing.Point(72, 47);
            this.textBoxDescriptio.Name = "textBoxDescriptio";
            this.textBoxDescriptio.Size = new System.Drawing.Size(119, 20);
            this.textBoxDescriptio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип данных";
            // 
            // AtNameTextBox
            // 
            this.AtNameTextBox.Location = new System.Drawing.Point(72, 22);
            this.AtNameTextBox.Name = "AtNameTextBox";
            this.AtNameTextBox.Size = new System.Drawing.Size(119, 20);
            this.AtNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // dataGridViewATT
            // 
            this.dataGridViewATT.AllowUserToAddRows = false;
            this.dataGridViewATT.AllowUserToDeleteRows = false;
            this.dataGridViewATT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewATT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameAt,
            this.Description,
            this.Type,
            this.TypeAt});
            this.dataGridViewATT.Location = new System.Drawing.Point(5, 79);
            this.dataGridViewATT.MultiSelect = false;
            this.dataGridViewATT.Name = "dataGridViewATT";
            this.dataGridViewATT.ReadOnly = true;
            this.dataGridViewATT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewATT.Size = new System.Drawing.Size(443, 190);
            this.dataGridViewATT.TabIndex = 16;
            // 
            // NameAt
            // 
            this.NameAt.HeaderText = "Название";
            this.NameAt.Name = "NameAt";
            this.NameAt.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип данных";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // TypeAt
            // 
            this.TypeAt.HeaderText = "Тип Атрибута";
            this.TypeAt.Name = "TypeAt";
            this.TypeAt.ReadOnly = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(747, 240);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(665, 240);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Заполнить базу данных";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridViewATT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmAttributes";
            this.Text = "Attributes";
            this.Load += new System.EventHandler(this.FrmAttributes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewATT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TypeAttribute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button DeleteAttribute;
        private System.Windows.Forms.Button ChangeAttribute;
        private System.Windows.Forms.Button AddAttribute;
        private System.Windows.Forms.TextBox textBoxDescriptio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AtNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewATT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeAt;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
    }
}