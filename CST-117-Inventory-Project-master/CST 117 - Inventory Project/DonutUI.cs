using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117___Inventory_Project
{
    public partial class DonutUI : Form
    {
        public DonutUI()
        {
            InitializeComponent();
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
            try
            {
                List<string> selectedItems = new List<string>();
                string item = DonutList1.SelectedItem.ToString();
                if (!selectedItems.Contains(item))
                {
                    selectedItems.Add(item);
                }

            }
            catch (Exception E)
            {
                MessageBox.Show("Please select an item from the list");
          
            }
        }
    }
}
