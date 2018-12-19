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
    public partial class FrmAttributes : Form
    {
        DataModelContainer model;
        Table table;
        List<Type> typeList = new List<CaseSystemApp.Type>();
        List<Column> columnList = new List<Column>();

        public FrmAttributes(DataModelContainer m, Table t)
        {
            InitializeComponent();
            model = m;
            table = t;
        }

        private void FrmAttributes_Load(object sender, EventArgs e)
        {
            comboBox1.Text = table.Name;
            comboBox1.Enabled = false;

            string[] key = new string[] { "Ключевой", "Не ключевой" };
            TypeAttribute.DataSource = key;

            string[] type = new string[] {"string", "int", "bool" };
            TypeComboBox.DataSource = type;

            List<Column> columns = model.ColumnSet.Where(x=>x.Table.Id==table.Id).ToList();

            foreach (Column c in columns)
            {
                dataGridViewATT.Rows.Add();
                dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[0].Value = c.Name;
                //dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[1].Value = ;
                dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[2].Value = c.Type.Name;
                if (c.Key)
                dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[3].Value = "Ключевой";
                else
                    dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[3].Value = "Не ключевой";
            }
        }

        private void AddAttribute_Click(object sender, EventArgs e)
        {
            Column column = new Column();
            bool key=false;
            
                string name = AtNameTextBox.Text;
            if (name != "")
            {
                string description = textBoxDescriptio.Text;
                if (TypeAttribute.SelectedItem.ToString() == "Ключевой")
                    key = true;

                string type = TypeComboBox.SelectedItem.ToString();

                // создаем TYPE, делаем связь с Column, кидаем его в массив
                Type currentType = new CaseSystemApp.Type();
                column.Type = currentType;
                currentType.Column.Add(column);
                currentType.Name = type;
                currentType.SqlNameType = type;
                typeList.Add(currentType);

//if (TypeComboBox.SelectedItem.ToString() == "int") Type


                dataGridViewATT.Rows.Add();
                dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[0].Value = name;
                dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[1].Value = description;
                dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[2].Value = type;
                dataGridViewATT.Rows[dataGridViewATT.RowCount - 1].Cells[3].Value =
                    TypeAttribute.SelectedItem.ToString();


                //server.DataBase.Add(database);
                //model.DataBaseSet.Add(database);
                //model.SaveChanges();

                column.Name = name;
                column.Key = key;
                column.Type = currentType;
                column.NotNull = "true";
                column.Increment = false;
                //if (table.Id.ToString()=="1")
                //column. = 1;


                table.Column.Add(column);


                model.ColumnSet.Add(column);
                model.SaveChanges();
            }
            else MessageBox.Show("Не указано имя атрибута");
            }

        private void DeleteAttribute_Click(object sender, EventArgs e)
        {

        }
    }
}
