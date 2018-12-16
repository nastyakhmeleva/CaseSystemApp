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
    public partial class ChangeServer : Form
    {
        DataModelContainer model;
        Server server;
        public ChangeServer(DataModelContainer m, Server s)
        {
            InitializeComponent();
            model = m;
            server = s;
            ServerName.Text = server.Name.ToString();
            
        }
        private void SaveServer_Click(object sender, EventArgs e)
        {
            
            if (ServerName == null)
                MessageBox.Show("Нельзя создать сервер. Пожалуйста, введите его название.");
            else
            {
                bool flag = false;
                if (model.ServerSet != null)
                {
                    foreach (Server c in model.ServerSet)
                        if (c.Name == ServerName.Text)
                            flag = true;
                }
                if (flag)
                    MessageBox.Show("Сервер с таким именем уже зарегистрирован в системе. Пожалуйста, придумайте другое название.");
                else
                {
                    server.Name = ServerName.Text;
                    model.ServerSet.Where(x => x.Id == server.Id).FirstOrDefault().Name = ServerName.Text;
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
