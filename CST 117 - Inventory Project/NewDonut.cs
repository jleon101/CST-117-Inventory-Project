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
    public partial class NewDonut : Form
    {
        private OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Leon\Desktop\MODfiles\CST117-InventoryProject\tst_InventorySystem.mdb");
        public NewDonut()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leon\Desktop\MOD files\tst_InventorySystem.mdb Persist Security Info=False;";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DonutUI newdonut = new DonutUI();
            newdonut.Tag = this;
            newdonut.Show(this);
            Hide();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            tboxID.Text = "";
            tboxDonutName.Text = "";
            tboxDescription.Text = "";
            tboxQuantity.Text = "";
            tboxPrice.Text = "";
        }

        private void NewDonut_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();      
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Donut values('"+tboxID.Text+"','"+tboxDonutName.Text+"','"+tboxDescription.Text+"','"+tboxQuantity.Text+"','"+tboxPrice+"')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
    }
}
