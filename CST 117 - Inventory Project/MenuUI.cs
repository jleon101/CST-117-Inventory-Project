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
    public partial class MenuUI : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public MenuUI()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leon\Desktop\MOD files\tst_InventorySystem.mdb Persist Security Info=False;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyBoxUI MyBoxForm = new MyBoxUI();
            MyBoxForm.Tag = this;
            MyBoxForm.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DrinksUI DrinksForm = new DrinksUI();
            DrinksForm.Tag = this;
            DrinksForm.Show(this);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DonutUI DonutForm = new DonutUI();
            DonutForm.Tag = this;
            DonutForm.Show(this);
            Hide();
        }

        private void MenuUI_Load(object sender, EventArgs e)
        {

        }
    }
}
