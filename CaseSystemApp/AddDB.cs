using System;
using System.Linq;
using System.Windows.Forms;

namespace CaseSystemApp
{
    public partial class AddDB : Form
    {
        public static DataModelContainer model = new DataModelContainer();
        public static Server server;
        public AddDB(DataModelContainer m, Server s)
        {
            InitializeComponent();
            model = m;
            server = s;
        }
        private void SaveDB_Click(object sender, EventArgs e)
        {
            var db = model.DataBaseSet.Where(u => u.Name.Contains(NameTextBox.Text)).ToList();
            if (db.Count <= 0)
            {
                if (NameTextBox.Text != "")
                {
                    DataBase dbase = new DataBase()
                    {
                        Name = NameTextBox.Text,
                        Server = server,
                    };
                    server.DataBase.Add(dbase);
                    model.DataBaseSet.Add(dbase);
                    model.SaveChanges();
                }
                else if (NameTextBox.Text == "") MessageBox.Show("Вы не указали имя базы данных");
            }
            else MessageBox.Show("База данных с указанным именем уже существует");

            this.Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Отменить добавление новой базы данных?",
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
