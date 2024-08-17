using Entidades;
using Negocio;
using System;
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
    public partial class Password : Form
    {
        string? userName;
        public Password()
        {
            InitializeComponent();
        }
        public Password(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            UsuarioLogin a = new UsuarioLogin();
            if (textBox2.Text == textBox3.Text)
            {
                a.NombreUsuario = userName;
                a.OldPassword = textBox1.Text;
                a.Password = textBox2.Text;
                bool success = await LoginNegocio.ChangePass(a);
                if (success)
                {
                    MessageBox.Show("Su contraseña a sido modificada con exito!", "Contraseña modificada");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar su contraseña!", "Error");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            else
            {
                MessageBox.Show("La nueva contraseña y el campo repite nueva contraseña deben ser iguales!", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
