using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace FaceRecognitionSystem
{
    public partial class RecordForm : Form
    {
        MySqlDataAdapter sda;
        //MySqlCommandBuilder scb;
        DataTable dt;

        public RecordForm()
        {
            InitializeComponent();
            displayData();

        }

        public void displayData()
        {
            MySqlConnection con = null;
            con = DBConnection.GetDBConnection();

            sda = new MySqlDataAdapter(@"SELECT id,fname,lname,allias,gender,age,nation,religion,status,offense,btype,tatoo,eye,skin,hair,address FROM crecord", con);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells[0].Value);

                MySqlConnection con = null;
                con = DBConnection.GetDBConnection();

                MySqlCommand cmd = new MySqlCommand(@"SELECT img FROM crecord WHERE id = " + a + "", con);

                try
                {
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        byte[] imgs = (byte[])dr["img"];
                        MemoryStream ms = new MemoryStream(imgs);
                        ms.Seek(0, SeekOrigin.Begin);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Selected = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string a = Convert.ToString(selectedRow.Cells[0].Value);

                    MySqlConnection con = null;
                    con = DBConnection.GetDBConnection();

                    MySqlCommand cmd = new MySqlCommand(@"DELETE FROM crecord WHERE id = " + a + "", con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Successfully Deleted Record", "Delete", MessageBoxButtons.OK);
                    displayData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "ID")
            {
                MySqlConnection con = null;
                con = DBConnection.GetDBConnection();

                sda = new MySqlDataAdapter(@"SELECT id,fname,lname,allias,gender,age,nation,religion,status,offense,btype,tatoo,eye,skin,hair,address FROM crecord WHERE id LIKE '" + textBox1.Text + "%' ", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }else if(comboBox1.Text == "FIRST NAME")
            {
                MySqlConnection con = null;
                con = DBConnection.GetDBConnection();

                sda = new MySqlDataAdapter(@"SELECT id,fname,lname,allias,gender,age,nation,religion,status,offense,btype,tatoo,eye,skin,hair,address FROM crecord WHERE fname LIKE '" + textBox1.Text + "%' ", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }else if(comboBox1.Text == "LAST NAME")
            {
                MySqlConnection con = null;
                con = DBConnection.GetDBConnection();

                sda = new MySqlDataAdapter(@"SELECT id,fname,lname,allias,gender,age,nation,religion,status,offense,btype,tatoo,eye,skin,hair,address FROM crecord WHERE lname LIKE '" + textBox1.Text + "%' ", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

            }else if(comboBox1.Text == "OFFENSE")
            {
                MySqlConnection con = null;
                con = DBConnection.GetDBConnection();

                sda = new MySqlDataAdapter(@"SELECT id,fname,lname,allias,gender,age,nation,religion,status,offense,btype,tatoo,eye,skin,hair,address FROM crecord WHERE OFFENSE LIKE '" + textBox1.Text + "%' ", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }
    }
}
