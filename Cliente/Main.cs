﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void botonUsuarios_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void botonReuniones_Click(object sender, EventArgs e)
        {

        }
    }
}
