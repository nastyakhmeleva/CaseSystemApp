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
    public partial class FormMain : Form
    {
        DataModelContainer model = new DataModelContainer();

        public FormMain()
        {
            InitializeComponent();
            ShowComboBoxes();
        }

        public void ShowComboBoxes()
        {
            ServerList.Items.Clear();
            foreach (Server server in model.ServerSet)
            {
                ServerList.Items.Add(server.Name);
            }
            DBList.Items.Clear();
            foreach (DataBase db in model.DataBaseSet)
            {
                DBList.Items.Add(db.Name);
            }
        }
        #region Server
        private void AddServer_Click(object sender, EventArgs e)
        {
            AddServer AddServer = new AddServer(model);
            AddServer.ShowDialog();
            ServerList.DataSource = model.ServerSet.ToList();
            ServerList.DisplayMember = "Name";
        }
        private void ServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server temp = (Server)ServerList.SelectedItem;
            List<DataBase> list = model.DataBaseSet.Where(p => p.Server.Id == temp.Id).ToList();
            DBList.DataSource = list;
        }
        private void ChangeServer_Click(object sender, EventArgs e)
        {
            //foreach (Server server in model.ServerSet)
            //{
            //    if (server.Name==ChangeServer.)
            //}
            //ChangeServer changeServer = new ChangeServer(Int32.Parse());
            //Server server = (Server)ServerList.SelectedItem;
            //ChangeServer ChangeServer = new ChangeServer();
           // ChangeServer.ShowDialog();
            ServerList.DataSource = model.ServerSet.ToList();
            ServerList.DisplayMember = "Name";
        }
        #endregion
        #region DataBase
        private void AddDB_Click(object sender, EventArgs e)
        {
            Server server = (Server)ServerList.SelectedItem;
            AddDB AddDB = new AddDB(model, server);
            AddDB.ShowDialog();

            List<DataBase> list = model.DataBaseSet.Where(p => p.Server.Id == server.Id).ToList();
            DBList.DataSource = list;
            DBList.DisplayMember = "Name";
        }
        private void DBList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataBase db = (DataBase)DBList.SelectedItem;
            List<Table> list = model.TableSet.Where(p => p.DataBase.Id == db.Id).ToList();
            //List<Table> list2 = model.TableSet.Where(p => p.DataBase.Id == temp2.Id).ToList();
            EntityList.DataSource = list;
            EntityList.DisplayMember = "Name";
        }
        private void ChangeDB_Click(object sender, EventArgs e)
        {
            DataBase database = (DataBase)DBList.SelectedItem;
            Server server = (Server)ServerList.SelectedItem;
            ChangeDB OpenDB = new ChangeDB(model, database, server);
            OpenDB.ShowDialog();
            DBList.DataSource = model.DataBaseSet.ToList();
            DBList.DisplayMember = "Name";
        }
#endregion
        private void AddEntity_Click(object sender, EventArgs e)
        {
            DataBase db = (DataBase)DBList.SelectedItem;
            AddEntity AddEntity = new AddEntity(db, model);
            AddEntity.ShowDialog();

            DataBase temp2 = (DataBase)DBList.SelectedItem;
            List<Table> list2 = model.TableSet.Where(p => p.DataBase.Id == temp2.Id).ToList();
            EntityList.DataSource = list2;
            EntityList.DisplayMember = "Name";
        }
        private void ShowEntity_Click(object sender, EventArgs e)
        {
            Table table = (Table)EntityList.SelectedItem;

            //Close();

            FrmAttributes form = new FrmAttributes(model, table);
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Заполнение выпадающего списка сущностями из БД
            ServerList.DataSource = model.ServerSet.ToList();
            ServerList.DisplayMember = "Name";

            Server temp = (Server)ServerList.SelectedItem;
            if (temp != null)
            {
                List<DataBase> list = model.DataBaseSet.Where(p => p.Server.Id == temp.Id).ToList();
                DBList.DataSource = list;
                DBList.DisplayMember = "Name";
            }

            DataBase temp2 = (DataBase)DBList.SelectedItem;
            if (temp2 != null)
            {
                List<Table> list2 = model.TableSet.Where(p => p.DataBase.Id == temp2.Id).ToList();
                EntityList.DataSource = list2;
                EntityList.DisplayMember = "Name";
            }
            if (ServerList.SelectedItem != null) AddDB.Enabled = true;
            if (DBList.SelectedItem != null) AddEntity.Enabled = true;
        }
    }
}
