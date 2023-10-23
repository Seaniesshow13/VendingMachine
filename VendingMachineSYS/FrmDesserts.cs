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
    public partial class FrmDesserts : Form
    {
        public FrmDesserts()
        {
            InitializeComponent();
        }

        private void btnBackDesserts_Click(object sender, EventArgs e)
        {
            Form to = new FrmOrderScreen();
            to.Show();
            this.Close();
        }
    }
}
