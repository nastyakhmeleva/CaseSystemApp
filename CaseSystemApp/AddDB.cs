using System;
using System.Windows.Forms;

namespace CaseSystemApp
{
    public partial class AddDB : Form
    {
        DataModelContainer model;
        Server server;
        public AddDB(DataModelContainer m, Server s)
        {
            InitializeComponent();
            model = m;
            server = s;
        }
        private void SaveDB_Click(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength == 0)
                MessageBox.Show("Нельзя создать базу данных. Пожалуйста, введите ее название.");

            else
            {
                bool flag = false;
                foreach (DataBase c in model.DataBaseSet)
                    if (c.Name == NameTextBox.Text)
                        flag = true;
                if (flag == true)
                    MessageBox.Show("База данных с таким именем уже зарегистрирована в системе. Пожалуйста, придумайте другое название.", "Ошибка!");
                else
                {
                    DataBase database = new DataBase();
                    database.Name = NameTextBox.Text;
                    database.Server = server;
                    server.DataBase.Add(database);
                    model.DataBaseSet.Add(database);
                    model.SaveChanges();
                    Close();
                }
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
