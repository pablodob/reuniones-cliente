using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            if (token != null)
            {
                List<ReunionUsuario> invitaciones = (List < ReunionUsuario > )await ReunionUsuarioNegocio.GetbyUsuario();
                foreach (ReunionUsuario ru in invitaciones)
                {
                    if (ru.Reunion != null) { 
                        MessageBox.Show("Usted a sido invitado a la reunión " + ru.Reunion.Titulo + " a realizarse el " + ru.Reunion.FechaHora.ToString(), "Nueva reunión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ru.Estado = "Invitado";
                        await ReunionUsuarioNegocio.Update(ru);
                    }
                }
                //MessageBox.Show("Ingreso correcto: "+  token, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
                Dispose();
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DataUsuario().ShowDialog();
        }
    }
}
