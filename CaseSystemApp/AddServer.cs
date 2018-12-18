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
        public static DataModelContainer model=new DataModelContainer();
        public AddServer(DataModelContainer m)
        {
            InitializeComponent();
            model = m;
        }
        private void SaveServer_Click(object sender, EventArgs e)
        {
            var servers = model.ServerSet.Where(u => u.Name.Contains(NameTextBox.Text)).ToList();
            if (servers.Count <= 0)
            {
                if (NameTextBox.Text != "")
                {
                    Server server = new Server()
                    {
                        Name = NameTextBox.Text
                    };
                    model.ServerSet.Add(server);
                    model.SaveChanges();
                }
                else if (NameTextBox.Text == "") MessageBox.Show("Вы не указали имя сервера");
            }
            else MessageBox.Show("Сервер с указанным именем уже существует");

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление нового сервера?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
