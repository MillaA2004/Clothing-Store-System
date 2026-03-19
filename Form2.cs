using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drehiDataSet.StaffInformation' table. You can move, or remove it, as needed.
            this.staffInformationTableAdapter.Fill(this.drehiDataSet.StaffInformation);
            // TODO: This line of code loads data into the 'drehiDataSet.ReceiptsProducts' table. You can move, or remove it, as needed.
            this.receiptsProductsTableAdapter.Fill(this.drehiDataSet.ReceiptsProducts);
            // TODO: This line of code loads data into the 'drehiDataSet.Receipts' table. You can move, or remove it, as needed.
            this.receiptsTableAdapter.Fill(this.drehiDataSet.Receipts);
            // TODO: This line of code loads data into the 'drehiDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.drehiDataSet.Products);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
