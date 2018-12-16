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
    public partial class OpenDB : Form
    {
        public OpenDB()
        {
            InitializeComponent();
        }

        DataModelContainer model;
        DataBase database;
        Server server;
        public OpenDB(DataModelContainer m, DataBase db, Server s)
        {
            InitializeComponent();
            model = m;
            database = db;
            server = s;
            DBName.Text = database.Name.ToString();

        }

        //MetaData1Entities cont = new MetaData1Entities();

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        private void OpenDB_Load(object sender, EventArgs e)
        {

        }

        private void SaveDB_Click(object sender, EventArgs e)
        {
            if (DBName.TextLength == 0)
                MessageBox.Show("Нельзя создать сущность. Пожалуйста, введите ее название.", "Ошибка!");

            else
            {
                bool flag = false;
                foreach (DataBase c in model.DataBaseSet)
                    if (c.Name == DBName.Text)
                        flag = true;
                if (flag == true)
                    MessageBox.Show("База данных с таким именем уже зарегистрирована в системе. Пожалуйста, придумайте другое название.", "Ошибка!");
                else
                {
                    //DataBase database = new DataBase();
                    database.Name = DBName.Text;
                    database.Server = server;
                    server.DataBase.Add(database);
                   // model.DataBaseSet.Add(database);
                    database.Name = DBName.Text;
                    model.ServerSet.Where(x => x.Id == database.Id ).FirstOrDefault().Name = DBName.Text;
                    model.SaveChanges();
                    Close();
                }
            }
        }
    }
}
