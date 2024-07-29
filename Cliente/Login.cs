﻿using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UsuarioLogin a = new UsuarioLogin();
            a.NombreUsuario = textBox1.Text;
            a.Password = textBox2.Text;
            String? token = await LoginNegocio.Send(a);
            if (token != null) { 
                //MessageBox.Show("Ingreso correcto: "+  token, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                new Main().ShowDialog();
            }
            Dispose();
        }

    }
}
