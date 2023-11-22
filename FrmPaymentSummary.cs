using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace VendingMachineSYS
{
    public partial class FrmPaymentSummary : Form
    {
        public FrmPaymentSummary()
        {
            InitializeComponent();
        }

        private void frmPaymentSummaryLoad(object sender, EventArgs e)
        {

        }

        public static void loadDGV(DataGridView dgvName, TextBox text)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            string orderNum = Orders.getOrderId().ToString();

            String strSQL = "SELECT * from order WHERE orderNumber like" + "'" + orderNum + "'";

            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(strSQL, conn);
            DataTable dataTable = new DataTable();

            oracleDataAdapter.Fill(dataTable);

            dgvName.DataSource = dataTable;
            conn.Close();

        }

        private void btnBackPayment_Click(object sender, EventArgs e)
        {
            Form to = new FrmOrderScreen();
            to.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPaymentSummary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been confirmed, Thank you", "Confirmation");
        }
    }
}
