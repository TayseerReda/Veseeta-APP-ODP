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
    public partial class Form4 : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter adapter;
        DataSet ds;
        public Form4()
        {
            InitializeComponent();
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            string constr = "data source=orcl; user id=scott; password=tiger;";
            string cmdstr = @"select *
                            from DOCTOR_APPOINTMENTS
                            where APTID= LOWER(:n)";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", patientID.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            appointmentGrid.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm hf=new homeForm();
            hf.Show();
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
