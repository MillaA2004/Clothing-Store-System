using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clothes
{

    public partial class Form3 : Form
    {
        private readonly string connString = @"Server=(localdb)\MSSQLLocalDB; Database=drehi; Trusted_Connection=True;";

        public Form3()
        {
            InitializeComponent();
        }

        private void LoadData(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    dAdapter.Fill(ds);

                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    // Note: conn.Close() is not needed here because the 'using' block automatically closes it
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Products ORDER BY ProductType";
            LoadData(query);
            label1.Text = "List of all products sorted by type";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Products ORDER BY DeliveryDate";
            LoadData(query);
            label1.Text = "List of all products sorted by delivery date";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Products ORDER BY ProductNumber DESC";
            LoadData(query);
            label1.Text = "List of all products sorted by product number";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Products WHERE Gender='m'";
            LoadData(query);
            label1.Text = "List of menswear products";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Products WHERE Gender='f'";
            LoadData(query);
            label1.Text = "List of womenswear products";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1_Click(this, EventArgs.Empty); 
        }
    }
}