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
    public partial class ChangeDB : Form
    {
        DataModelContainer model;
        DataBase database;
        Server server;
        public ChangeDB(DataModelContainer m, DataBase db, Server s)
        {
            InitializeComponent();
            model = m;
            database = db;
            server = s;
            DBName.Text = database.Name.ToString();

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveDB_Click(object sender, EventArgs e)
        {
            if (DBName.TextLength == 0)
                MessageBox.Show("Нельзя сохранить базу данных. Пожалуйста, введите ее название.");

            else
            {
                bool flag = false;
                foreach (DataBase c in model.DataBaseSet)
                    if (c.Name == DBName.Text)
                        flag = true;
                if (flag)
                    MessageBox.Show("База данных с таким именем уже зарегистрирована в системе. Пожалуйста, придумайте другое название.", "Ошибка!");
                else
                {
                    database.Name = DBName.Text;
                    database.Server = server;
                    server.DataBase.Add(database);
                    database.Name = DBName.Text;
                    model.ServerSet.Where(x => x.Id == database.Id ).FirstOrDefault().Name = DBName.Text;
                    model.SaveChanges();
                    Close();
                }
            }
        }
    }
}
