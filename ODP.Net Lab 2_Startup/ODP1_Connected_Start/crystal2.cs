using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace ODP1_Connected_Start
{
    public partial class crystal2 : Form
    {
        CrystalReport2 CR;
        public crystal2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            CR.SetParameterValue(1, comboBox2.Text);
            crystalReportViewer1.ReportSource = CR;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crystal2_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();

            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
            foreach (ParameterDiscreteValue v in CR.ParameterFields[1].DefaultValues)
                comboBox2.Items.Add(v.Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }
    }
}
