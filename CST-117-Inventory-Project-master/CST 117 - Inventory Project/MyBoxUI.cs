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
    public partial class MyBoxUI : Form
    {
        public MyBoxUI()
        {
            InitializeComponent();
        }

        private void MyBoxMenuButton_Click(object sender, EventArgs e)
        {
            MenuUI MenuForm = new MenuUI();
            MenuForm.Tag = this;
            MenuForm.Show(this);
            Hide();
        } 

        private void PayNowButton_Click(object sender, EventArgs e)
        {
            PayNowUI PayNowForm = new PayNowUI();
            PayNowForm.Tag = this;
            PayNowForm.Show(this);
            Hide();
        }
    }
}
