using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace FaceRecognitionSystem
{
    class DBRecord
    {
        private int id;
        private byte[] img;
        private string fname;
        private string lname;
        private string allias;
        private string gender;
        private int age;
        private string nation;
        private string religion;
        private string status;
        private string offense;
        private string btype;
        private string tatoo;
        private string eye;
        private string skin;
        private string hair;
        private string address;

        public int ID
        {
            get { return id; }
            set { this.id = value; }
        }

            
        public string FNAME
        {
            get { return fname; }
            set { this.fname = value; }
        }
        public string LNAME
        {
            get { return lname; }
            set { this.lname = value; }
        }
        public string ALLIAS
        {
            get { return allias; }
            set { this.allias = value; }
        }
        public string GENDER
        {
            get { return gender; }
            set { this.gender = value; }
        }
        public int AGE
        {
            get { return age; }
            set { this.age = value; }
        }
        public string NATION
        {
            get { return nation; }
            set { this.nation = value; }
        }
        public string RELIGION
        {
            get { return religion; }
            set { this.religion = value; }
        }
        public string STATUS
        {
            get { return status; }
            set { this.status = value; }
        }
        public string OFFENSE
        {
            get { return offense; }
            set { this.offense = value; }
        }
        public string BTYPE
        {
            get { return btype; }
            set { this.btype = value; }
        }
        public string TATOO
        {
            get { return tatoo; }
            set { this.tatoo = value; }
        }
        public string EYE
        {
            get { return eye; }
            set { this.eye = value; }
        }
        public string SKIN
        {
            get { return skin; }
            set { this.skin = value; }
        }
        public string HAIR
        {
            get { return hair; }
            set { this.hair = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { this.address = value; }
        }

       public byte[] IMG
        {
            get { return img; }
            set { this.img = value; }
        }
    
        public void Add()
        {
            
            MySqlConnection con = null;
            con = DBConnection.GetDBConnection();

            String cmdText = "INSERT INTO crecord VALUES(0,@fname,@lname,@allias,@gender,@age,@nation,@religion," +
                             "@status,@offense,@btype,@tatoo,@eye,@skin,@hair,@address,@img)";

            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@allias", allias);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@nation", nation);
            cmd.Parameters.AddWithValue("@religion", religion);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@offense", offense);
            cmd.Parameters.AddWithValue("@btype", btype);
            cmd.Parameters.AddWithValue("@tatoo", tatoo);
            cmd.Parameters.AddWithValue("@eye", eye);
            cmd.Parameters.AddWithValue("@skin", skin);
            cmd.Parameters.AddWithValue("@hair", hair);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@img", img);
            cmd.ExecuteNonQuery();
        }

      /*  public static DBRecord GetUser(int personId)
        {
            DBRecord dbrecord = null;
            string cmdText;
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();


            cmdText = "SELECT * FROM crecord ";
            cmdText += "WHERE id=" + personId;

            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            MySqlDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    dbrecord = new DBRecord();

                    dbrecord.ID = reader.GetInt32(0);
                    dbrecord.FNAME = reader.GetString(1);
                    dbrecord.LNAME = reader.GetString(2);
                    dbrecord.ALLIAS = reader.GetString(3);
                    dbrecord.GENDER = reader.GetString(4);
                    dbrecord.AGE = reader.GetInt32(5);
                    dbrecord.NATION = reader.GetString(6);
                    dbrecord.RELIGION = reader.GetString(7);
                    dbrecord.STATUS = reader.GetString(8);
                    dbrecord.OFFENSE = reader.GetString(9);
                    dbrecord.BTYPE = reader.GetString(10);
                    dbrecord.TATOO = reader.GetString(11);
                    dbrecord.EYE = reader.GetString(12);
                    dbrecord.SKIN = reader.GetString(13);
                    dbrecord.HAIR = reader.GetString(14);
                    dbrecord.ADDRESS = reader.GetString(15);

                }

                reader.Close();

            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            finally
            {
                con.Close();
            }

            return dbrecord;
        } */

        public static List<DBRecord> GetUsers()
        {
            List<DBRecord> users = new List<DBRecord>();
            String cmdText;
            MySqlDataReader reader = null;

            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();
            cmdText = "SELECT * FROM crecord";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    DBRecord dbrecord = new DBRecord();

                    dbrecord.ID = reader.GetInt32(0);
                    dbrecord.FNAME = reader.GetString(1);
                    dbrecord.LNAME = reader.GetString(2);
                    dbrecord.ALLIAS = reader.GetString(3);
                    dbrecord.GENDER = reader.GetString(4);
                    dbrecord.AGE = reader.GetInt32(5);
                    dbrecord.NATION = reader.GetString(6);
                    dbrecord.RELIGION = reader.GetString(7);
                    dbrecord.STATUS = reader.GetString(8);
                    dbrecord.OFFENSE = reader.GetString(9);
                    dbrecord.BTYPE = reader.GetString(10);
                    dbrecord.TATOO = reader.GetString(11);
                    dbrecord.EYE = reader.GetString(12);
                    dbrecord.SKIN = reader.GetString(13);
                    dbrecord.HAIR = reader.GetString(14);
                    dbrecord.ADDRESS = reader.GetString(15);
                    byte[] buff = new byte[1024];
                    long bytee = 0;
                    MemoryStream stream = new MemoryStream();
                    BinaryWriter writer = new BinaryWriter(stream);
                    bytee = reader.GetBytes(1,0,buff,0,buff.Length);

                    while(true)
                    {
                        try
                        {
                           // bytee = reader.GetBytes();
                            writer.Write(buff);
                        }
                        catch(Exception e)
                        {
                            writer.Flush();
                            writer.Close();
                            break;
                        }
                    }
                    dbrecord.img = buff;

        
                    users.Add(dbrecord);
                }
            }

            reader.Close();
            return users;
        }
    }
}
