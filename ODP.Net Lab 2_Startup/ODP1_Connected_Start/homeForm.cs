using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP1_Connected_Start
{
    public partial class homeForm : Form
    {
        
        OracleCommandBuilder builder;
        OracleDataAdapter adapter;
        DataSet ds;


        public homeForm()
        {
            InitializeComponent();
        }


        //private void search_bt_Click(object sender, EventArgs e)
        //{
        //    string constr = "data source=orcl; user id=scott; password=tiger;";
        //    string cmdstr = @"select *
        //                    from LABS
        //                    where Location= LOWER(:n)";
        //    adapter = new OracleDataAdapter(cmdstr, constr);
        //    adapter.SelectCommand.Parameters.Add("n", lab_loc.Text);
        //    ds = new DataSet();
        //    adapter.Fill(ds);
        //    dataGridView2.DataSource = ds.Tables[0];
        //}

        //private void save_bt_Click(object sender, EventArgs e)
        //{
        //    builder = new OracleCommandBuilder(adapter);
        //    adapter.Update(ds.Tables[0]);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2= new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1= new Form1();
            f1.Show();
        }

        private void labPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3= new Form3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
