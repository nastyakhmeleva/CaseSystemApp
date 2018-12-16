using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseSystemApp
{
    public partial class AddEntity : Form
    {
        DataModelContainer model;
        DataBase dataBase;

        public AddEntity(DataBase db, DataModelContainer dmc)
        {
            InitializeComponent();
            model = dmc;
            dataBase = db;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveEntity_Click(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength == 0)
                MessageBox.Show("Нельзя создать сущность. Пожалуйста, введите ее название.", "Ошибка!");
            else
            {
                bool flag = false;
                foreach (Table c in model.TableSet)
                    if (c.Name == NameTextBox.Text)
                        flag = true;
                if (flag == true)
                    MessageBox.Show("Сущность с таким именем уже зарегистрирована в системе. Пожалуйста, придумайте другое название.", "Ошибка!");
                else
                {
                    Table table = new Table();
                    table.Name = NameTextBox.Text;
                    table.DataBase = dataBase;
                    dataBase.Table.Add(table);
                    model.TableSet.Add(table);
                    model.SaveChanges();
                    Close();

                    FrmAttributes form = new FrmAttributes(model, table);
                    form.ShowDialog();

                }
            }
        }

        private void AddEntity_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
