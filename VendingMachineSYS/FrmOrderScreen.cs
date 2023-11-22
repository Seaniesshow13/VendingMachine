using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSYS
{
    public partial class FrmOrderScreen : Form
    {
        public FrmOrderScreen()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }
        
        private void btnBurgers_Click(object sender, EventArgs e)
        {
            FrmBurgers to = new FrmBurgers();
            to.Show();
            this.Hide();
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            FrmDesserts to = new FrmDesserts();
            to.Show();
            this.Hide();
        }

        private void btnSides_Click(object sender, EventArgs e)
        {
            FrmSides to = new FrmSides();
            to.Show();
            this.Hide();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            FrmDrinks to = new FrmDrinks();
            to.Show();
            this.Hide();
        }

        private void btnWraps_Click(object sender, EventArgs e)
        {
            FrmWraps to = new FrmWraps();
            to.Show();
            this.Hide();
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            FrmPaymentSummary to = new FrmPaymentSummary();
            to.Show();
            this.Hide();
        }

        private void FrmOrderScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirmation", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true; // Cancel the form closing
            }
        }
    }
}
