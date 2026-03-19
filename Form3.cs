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
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Server=(localdb)\MSSQLLocalDB; Database = drehi; Trusted_Connection = True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"
                               SELECT*
                               FROM Products
                               ORDER BY ProductType
                               ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            label1.Text = "Списък на всички ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = @"Server=(localdb)\MSSQLLocalDB; Database = drehi; Trusted_Connection = True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"
                               SELECT*
                               FROM Products
                               ORDER BY DeliveryDate
                               ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            label1.Text = "Списък на всички";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string connString = @"Server=(localdb)\MSSQLLocalDB; Database = drehi; Trusted_Connection = True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"
                               SELECT*
                               FROM Products
                               ORDER BY ProductNumber DESC
                               ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            label1.Text = "Списък на всички";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string connString = @"Server=(localdb)\MSSQLLocalDB; Database = drehi; Trusted_Connection = True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"
                               SELECT*
                               FROM Products
                               Where Gender='m'
                               ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            label1.Text = "Списък на m";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connString = @"Server=(localdb)\MSSQLLocalDB; Database = drehi; Trusted_Connection = True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"
                               SELECT*
                               FROM Products
                               Where Gender='f'
                               ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    dAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

            label1.Text = "Списък на f";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}



