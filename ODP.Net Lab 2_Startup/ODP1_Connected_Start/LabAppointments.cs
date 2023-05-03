using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
    public partial class LabAppointments : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public LabAppointments()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Name  from Labs where Location=:loc";
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Show_test_name";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("loc", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("Lab_name", comboBox2.SelectedItem.ToString());
            cmd.Parameters.Add("test_name", OracleDbType.RefCursor, ParameterDirection.Output);
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

            }
            dr.Close();
            conn.Dispose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Show_price_requirement";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Loc", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("Lab_name", comboBox2.SelectedItem.ToString());
            cmd.Parameters.Add("test_name", comboBox3.SelectedItem.ToString());
            cmd.Parameters.Add("price", OracleDbType.Decimal, ParameterDirection.Output);
            cmd.Parameters.Add("Requirement", OracleDbType.Varchar2, 500).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            textBox1.Text = cmd.Parameters["price"].Value.ToString();
            textBox2.Text = cmd.Parameters["Requirement"].Value.ToString();

            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "LAB_APT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("PatID", textBox3.Text);
            cmd.Parameters.Add("Lab_name", comboBox2.SelectedItem.ToString());
            cmd.Parameters.Add("test_name", comboBox3.SelectedItem.ToString());
            cmd.Parameters.Add("APTDATE", Convert.ToDateTime(textBox4.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Appointment Lab Added");

            conn.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabAppointments_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Location from LABS";
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
    }
}
