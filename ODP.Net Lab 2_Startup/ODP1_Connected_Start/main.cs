﻿using System;
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crystals c = new crystals();
            c.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeForm h = new homeForm();
            h.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vezeeta r = new Vezeeta();
            r.Show();
        }
    }
}
