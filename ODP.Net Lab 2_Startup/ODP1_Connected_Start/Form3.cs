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
    public partial class Form3 : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter adapter;
        DataSet ds;
        public Form3()
        {
            InitializeComponent();
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            string constr = "data source=orcl; user id=scott; password=tiger;";
            string cmdstr = @"select MEDID, NAME,MEDICINE_TYPE, COUNT, PRICE
                            from Medicines
                            where Name= LOWER(:n)";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", medName.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            medGrid.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "data source=orcl; user id=scott; password=tiger;";
            string cmdstr = @"select MEDID, NAME, COUNT, PRICE
                            from Medicines";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            medGrid.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm hf = new homeForm();
            hf.Show();
        }
    }
}
