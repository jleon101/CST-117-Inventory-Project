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
    public partial class DrinksUI : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public DrinksUI()
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

        private void DonutMenuButton_Click(object sender, EventArgs e)
        {
            MyBoxUI MyBoxForm = new MyBoxUI();
            MyBoxForm.Tag = this;
            MyBoxForm.Show(this);
            Hide();
        }

        private void DrinksUI_Load(object sender, EventArgs e)
        {

        }
    }
}
