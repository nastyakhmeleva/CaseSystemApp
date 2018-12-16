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
    public partial class AddServer : Form
    {
        DataModelContainer model;
        public AddServer(DataModelContainer m)
        {
            InitializeComponent();
            model = m;
        }
        private void SaveServer_Click(object sender, EventArgs e)
        {
            if (NameTextBox == null)
                MessageBox.Show("Нельзя создать сервер. Пожалуйста, введите его название.");
            else
            {
                bool flag = false;
                if (model.ServerSet != null)
                {
                    foreach (Server c in model.ServerSet)
                        if (c.Name == NameTextBox.Text)
                            flag = true;
                }
                if (flag)
                    MessageBox.Show("Сервер с таким именем уже зарегистрирован в системе. Пожалуйста, придумайте другое название.");
                else
                {
                    Server server = new Server();
                    server.Name = NameTextBox.Text;
                    model.ServerSet.Add(server);
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
