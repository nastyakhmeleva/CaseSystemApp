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
        public static DataModelContainer model = new DataModelContainer();
        public static Server server;
        public ChangeServer(int id)
        {
            InitializeComponent();
            server = model.ServerSet.Find(id);
            ShowTextBox();
        }
        public void ShowTextBox()
        {
            ServerName.Text = server.Name;
        }
        private void SaveServer_Click(object sender, EventArgs e)
        {
            if (ServerName.Text != "")
            {
                if (server.Name != ServerName.Text)
                    server.Name = ServerName.Text;
                model.SaveChanges();
                Close();
            }
            else if (ServerName.Text == "") MessageBox.Show("Вы не указали название сервера");
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить изменение имени сервера?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
