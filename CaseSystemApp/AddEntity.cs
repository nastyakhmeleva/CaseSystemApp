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
        public static DataModelContainer model = new DataModelContainer();
        public static DataBase dataBase;

        public AddEntity(DataBase db, DataModelContainer dmc)
        {
            InitializeComponent();
            model = dmc;
            dataBase = db;
        }


        private void SaveEntity_Click(object sender, EventArgs e)
        {
            var entity = model.TableSet.Where(u => u.Name.Contains(NameTextBox.Text)).ToList();
            if (entity.Count <= 0)
            {
                if (NameTextBox.Text != "")
                {
                    Table table = new Table()
                    {
                        Name = NameTextBox.Text,
                        DataBase = dataBase
                    };
                    dataBase.Table.Add(table);
                    model.TableSet.Add(table);
                    model.SaveChanges();
                    Close();
                    FrmAttributes form = new FrmAttributes(model, table);
                    form.ShowDialog();
                }
                else if (NameTextBox.Text == "") MessageBox.Show("Вы не указали имя сущности");
            }
            else MessageBox.Show("Сущность с указанным именем уже существует");

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
