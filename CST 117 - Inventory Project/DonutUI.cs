using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CST_117___Inventory_Project
{
    public partial class DonutUI : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public DonutUI()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leon\Desktop\MOD files\tst_InventorySystem.mdb Persist Security Info=False;";
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuUI MenuForm = new MenuUI();
            MenuForm.Tag = this;
            MenuForm.Show(this);
            Hide();
        }

        private void MyBoxButton_Click(object sender, EventArgs e)
        {
            MyBoxUI MyBoxForm = new MyBoxUI();
            MyBoxForm.Tag = this;
            MyBoxForm.Show(this);
            Hide();
        }

        private void AddDonutButton_Click(object sender, EventArgs e)
        {
            NewDonut newdonut = new NewDonut();
            newdonut.Tag = this;
            newdonut.Show(this);
            Hide();
        }

        private void donutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.donutBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tst_InventorySystemDataSet);

        }

        private void DonutUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tst_InventorySystemDataSet.Donut' table. You can move, or remove it, as needed.
            this.donutTableAdapter.Fill(this.tst_InventorySystemDataSet.Donut);
            OleDbConnection conn = new OleDbConnection();
            
        }
    }
}
