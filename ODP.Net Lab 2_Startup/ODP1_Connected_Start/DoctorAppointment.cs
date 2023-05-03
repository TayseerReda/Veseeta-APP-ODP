using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ODP1_Connected_Start
{
    public partial class DoctorAppointment : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;



        public DoctorAppointment()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Name  from DOCTORS where Location=:loc And Speciality=:spe";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("loc", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("spe", comboBox2.SelectedItem.ToString());
            comboBox3.Items.Clear();
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (comboBox3.Items.Contains(dr[0].ToString()))
                {
                    continue;
                }
                else
                {
                    comboBox3.Items.Add(dr[0].ToString());
                }
                //comboBox3.Items.Add(dr[0].ToString());
                //comboBox3.Text = dr[1].ToString();
                //textBox1.Text = dr[2].ToString();
            }
            dr.Close();
            conn.Dispose();
        }

        private void DoctorAppointment_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Location from Doctors";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (comboBox1.Items.Contains(dr[0].ToString()))
                {
                    continue;
                }
                else
                {
                    comboBox1.Items.Add(dr[0].ToString());
                }

            }
            dr.Close();
            conn.Dispose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ID FROM DOCTORS where NAME=:name ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", comboBox3.SelectedItem.ToString());

            int id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select APTDATE from DOCTOR_APPOINTMENTS where DOCID=:id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", OracleDbType.Int32).Value = id;
            comboBox4.Items.Clear();
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr[0]);
            }

            dr.Close();
            conn.Dispose();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ID FROM DOCTORS where NAME=:name ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", comboBox3.SelectedItem.ToString());

            int id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select APTDATE from DOCTOR_APPOINTMENTS where DOCID=:id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", OracleDbType.Int32).Value = id;
            comboBox4.Items.Clear();
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr[0]);
            }

            dr.Close();
            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT MAX(BOOKINGID) FROM BOOKEDAPPOINTMENT";
            int maxID = Convert.ToInt32(cmd.ExecuteScalar());
            maxID += 1;

            cmd.Parameters.Clear(); // clear the parameters collection before adding new parameters

            cmd.CommandText = "SELECT ID FROM DOCTORS where NAME=:name ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", comboBox3.SelectedItem.ToString());
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Parameters.Clear(); // clear the parameters collection before adding new parameters

            cmd.CommandText = "SELECT APTID FROM DOCTOR_APPOINTMENTS where DOCID=:ID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ID", OracleDbType.Int32).Value = id;
            //cmd.Parameters.Add("APTDA", comboBox4.SelectedItem.ToString());
            int ApID = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Parameters.Clear(); // clear the parameters collection before adding new parameters

            cmd.CommandText = "INSERT INTO BOOKEDAPPOINTMENT values (:ID , :ApID ,:PID) ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ID", OracleDbType.Int32).Value = maxID;
            cmd.Parameters.Add("ApID", OracleDbType.Int32).Value = ApID;
            cmd.Parameters.Add("PID", textBox1.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Appointment Booked Successfully");

                Add add = new Add();
                add.ShowDialog();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Speciality  from DOCTORS where Location=:loc";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("loc", comboBox1.SelectedItem.ToString());
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (comboBox2.Items.Contains(dr[0].ToString()))
                {
                    continue;
                }
                else
                {
                    comboBox2.Items.Add(dr[0].ToString());
                }

                //comboBox3.Text = dr[1].ToString();
                //textBox1.Text = dr[2].ToString();
            }
            dr.Close();
            conn.Dispose();
        }
    }
}
