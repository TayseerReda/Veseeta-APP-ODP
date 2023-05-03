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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorAppointment doctorAppointment = new DoctorAppointment();
            doctorAppointment.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vezeeta Vezeeta = new Vezeeta();
            Vezeeta.ShowDialog();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void Add_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LabAppointments labAppointment = new LabAppointments();
            labAppointment.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
