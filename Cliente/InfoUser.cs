using Entidades;
using Microsoft.VisualBasic.ApplicationServices;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cliente
{
    public partial class InfoUser : Form
    {
        Usuario usuario;
        int UserId;
        bool isAdmin;

        public InfoUser()
        {
            InitializeComponent();
        }

        public InfoUser(int UserId, bool isAdmin)
        {
            this.UserId = UserId;
            this.isAdmin = isAdmin;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Password cambiopassword = new Password(usuario.NombreUsuario);
            cambiopassword.Show();
        }

        private async void InfoUser_Load(object sender, EventArgs e)
        {
            usuario = await UsuarioNegocio.GetUser(UserId);
            label2.Text = usuario.NombreUsuario;
            label4.Text = usuario.Nombre;
            if (isAdmin)
            {
                label5.Text = "Administrador";
            }
            else
            {
                label5.Text = "Usuario";
            }
        }
    }
}
