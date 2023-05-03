using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class Registerform : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Registerform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select PHONENUMBER , Email from PATIENTS where Phonenumber=:phnum OR Email=:email";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("phnum", textBox2.Text);
            cmd.Parameters.Add("email", textBox3.Text);

            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("This email already exists");
                reader.Close();
                conn.Close();
            }
            else
            {

                cmd.CommandText = "SELECT MAX(PATIENTID) FROM PATIENTS";
                int maxID = Convert.ToInt32(cmd.ExecuteScalar());
                maxID += 1;
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into PATIENTS (PATIENTID, NAME, PHONENUMBER, EMAIL, PASSWORD) values (:ID,:name,:phnum,:email,:pass)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("ID", OracleDbType.Int32).Value = maxID;
                cmd.Parameters.Add("name", textBox1.Text);
                cmd.Parameters.Add("phnum", textBox2.Text);
                cmd.Parameters.Add("email", textBox3.Text);
                cmd.Parameters.Add("pass", textBox4.Text);
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Registered Successfully");
                    MessageBox.Show("Your ID is :   " + maxID);
                    Add add = new Add();
                    add.ShowDialog();
                    reader.Close();
                    conn.Close();
                }
            }
        }

        private void Registerform_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
        }
    }
}
