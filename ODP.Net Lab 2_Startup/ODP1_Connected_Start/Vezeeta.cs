using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ODP1_Connected_Start
{
    public partial class Vezeeta : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Vezeeta()
        {
            InitializeComponent();
        }

        private void Vezeeta_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Registerform registerform = new Registerform();
            //registerform.ShowDialog();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //conn = new OracleConnection(ordb);
            //conn.Open();

            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "select Email from PATIENTS where Email=:email AND PASSWORD=:pass ";
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("email", textBox1.Text.ToString());
            //cmd.Parameters.Add("pass", textBox2.Text.ToString());
            ////cmd.Parameters.Add("password", textBox2.Text.ToString());
            //OracleDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{

            //    MessageBox.Show("Login Successfully");
            //    reader.Close();
            //    conn.Close();
            //    Add add = new Add();
            //    add.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("This email not exis");
            //    reader.Close();
            //    conn.Close();

            //}





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registerform registerform = new Registerform();
            registerform.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Email from PATIENTS where Email=:email AND PASSWORD=:pass ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", textBox1.Text.ToString());
            cmd.Parameters.Add("pass", textBox2.Text.ToString());
            //cmd.Parameters.Add("password", textBox2.Text.ToString());
            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                MessageBox.Show("Login Successfully");
                reader.Close();
                conn.Close();
                Add add = new Add();
                add.ShowDialog();
            }
            else
            {
                MessageBox.Show("This email not exis");
                reader.Close();
                conn.Close();

            }



        }
    }
}
