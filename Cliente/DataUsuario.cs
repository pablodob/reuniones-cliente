using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class DataUsuario : Form
    {
        public DataUsuario()
        {
            InitializeComponent();
            label4.Visible = false;
        }

        public DataUsuario(Usuario usuarioAModificar)
        {
            InitializeComponent();
            button1.Text = "Editar";
            textBox1.Text = usuarioAModificar.Nombre;
            textBox2.Text = usuarioAModificar.NombreUsuario;
            label5.Visible = false;
            textBox3.Visible = false;
            label4.Text = Convert.ToString(usuarioAModificar.Id);
            //textBox3.Enabled = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Usuario a = new Usuario();
            a.Nombre = textBox1.Text;
            a.NombreUsuario = textBox2.Text;
            a.Password = textBox3.Text;
            if (button1.Text == "Editar")
            {
                a.Id = Convert.ToInt32(label4.Text);
                await UsuarioNegocio.Update(a);
            }
            else { 
                await LoginNegocio.Add(a);
            }
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
