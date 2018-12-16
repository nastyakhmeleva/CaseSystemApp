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
        }

        private void AddAttribute_Click(object sender, EventArgs e)
        {
            Column column = new Column();
            bool key=false;
            
            string name = AtNameTextBox.Text;
            string description = textBoxDescriptio.Text;
            if (TypeAttribute.SelectedItem.ToString()=="Ключевой")
                key = true;
            if (TypeAttribute.SelectedItem.ToString() == "Не ключевой")
                key = false;
            
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
            dataGridViewATT.Rows[0].Cells[0].Value = name;
            dataGridViewATT.Rows[0].Cells[1].Value = description;
            dataGridViewATT.Rows[0].Cells[3].Value = TypeAttribute.SelectedItem.ToString();

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
    }
}
