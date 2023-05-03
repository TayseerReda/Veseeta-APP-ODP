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
    public partial class Form1 : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter adapter;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void lab_loc_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            string constr = "data source=orcl; user id=scott; password=tiger;";
            string cmdstr = @"select LABID, NAME, LOCATION
                            from LABS
                            where Location= LOWER(:n)";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", lab_loc.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm hf = new homeForm();
            hf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
