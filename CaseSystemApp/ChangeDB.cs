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
        private void SaveDB_Click(object sender, EventArgs e)
        {
            if (DBName.Text != "")
            {
                if (database.Name != DBName.Text)
                {
                    database.Name = DBName.Text;
                    database.Server = server;
                }
                server.DataBase.Add(database);
                model.ServerSet.Where(x => x.Id == database.Id).FirstOrDefault().Name = DBName.Text;
                model.SaveChanges();
                Close();
            }
            else if (DBName.Text == "") MessageBox.Show("Вы не указали название сервера");
            if (DBName.TextLength == 0)
                MessageBox.Show("Нельзя сохранить базу данных. Пожалуйста, введите ее название.");
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
