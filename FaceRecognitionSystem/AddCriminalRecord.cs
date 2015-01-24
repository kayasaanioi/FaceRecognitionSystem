using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;
using System.IO;
using MySql.Data.MySqlClient;

namespace FaceRecognitionSystem
{
    public partial class AddCriminalRecord : Form
    {
        public AddCriminalRecord()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                MessageBox.Show("Please enter Image in Picturebox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imgbyte = null;
            FileStream fstream = new FileStream(this.textBox12.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imgbyte = br.ReadBytes((int)fstream.Length);

            MySqlConnection con = null;
            con = DBConnection.GetDBConnection();

            String cmdText = "INSERT INTO crecord (fname,lname,allias,gender,age,nation,religion,status,offense,btype,tatoo,eye,skin,hair,address,img) VALUE ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.comboBox4.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "',@IMG);";

            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            MySqlDataReader myReader;

            try
            {
                cmd.Parameters.Add(new MySqlParameter("@IMG", imgbyte));
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Successfully Save Record", "Login", MessageBoxButtons.OK);

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            DBRecord dbrecord = new DBRecord();

          if (textBox12.Text == "")
            {
                MessageBox.Show("Please enter Image in Picturebox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          try
          {
              byte[] img = null;
              FileStream fstream = new FileStream(this.textBox12.Text, FileMode.Open, FileAccess.Read);
              BinaryReader br = new BinaryReader(fstream);
              img = br.ReadBytes((int)fstream.Length);


              dbrecord.FNAME = textBox1.Text;
              dbrecord.LNAME = textBox2.Text;
              dbrecord.ALLIAS = textBox3.Text;
              dbrecord.GENDER = comboBox4.SelectedItem.ToString();
              dbrecord.AGE = Convert.ToInt32(textBox4.Text);
              dbrecord.NATION = textBox5.Text;
              dbrecord.RELIGION = textBox6.Text;
              dbrecord.STATUS = comboBox1.SelectedItem.ToString();
              dbrecord.OFFENSE = comboBox2.SelectedItem.ToString();
              dbrecord.BTYPE = comboBox3.SelectedItem.ToString();
              dbrecord.TATOO = textBox7.Text;
              dbrecord.EYE = textBox8.Text;
              dbrecord.SKIN = textBox9.Text;
              dbrecord.HAIR = textBox10.Text;
              dbrecord.ADDRESS = textBox11.Text;
              dbrecord.IMG = imageToByteArray(pictureBox1.Image);
              //dbrecord.IMG = pictureBox1.Imag;


              dbrecord.Add();
              MessageBox.Show("Successfully Added!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
              clearTextBox();
          }
            catch(MySqlException ex)
          {
              MessageBox.Show("FAILED TO ADD RECORD");
          }
        }

        public void clearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
           OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picture = dlg.FileName.ToString();
                textBox12.Text = picture;
                pictureBox1.ImageLocation = picture;
            }
        }

      /*  public Image byteArrayToImage(byte[] byteArrayIn)
        {

             MemoryStream ms = new MemoryStream(byteArrayIn);
             Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }*/
    }
}
