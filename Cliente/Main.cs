using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Negocio;
using Entidades;

namespace Cliente
{
    public partial class Main : Form
    {
        private int? userId { get; set; }
        private string? userName { get; set; }
        private bool isAdmin { get; set; }

        private Usuario usuario = new Usuario();

        public Main()
        {
            InitializeComponent();
        }

        private void botonUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios form1 = new FormUsuarios();
            form1.MdiParent = this;
            form1.Show();
        }

        private void botonReuniones_Click(object sender, EventArgs e)
        {
            FormReuniones formReuniones = new FormReuniones(isAdmin, usuario.Id);
            formReuniones.MdiParent = this;
            formReuniones.Show();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userId != null)
            {
                InfoUser infouser = new InfoUser((int)userId, isAdmin);
                infouser.MdiParent = this;
                infouser.Show();
            }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            usuario = await UsuarioNegocio.GetMyUser();
            userId = usuario.Id;
            userName = usuario.NombreUsuario;
            if (usuario.Role == 0)
            {
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }
            string dataInfo = "Id: " + userId.ToString() + " | Usuario: " + userName + " | Rol: ";
            if (isAdmin)
            {
                dataInfo += "Administrador";
            }
            else
            {
                dataInfo += "Usuario";
                this.botonUsuarios.Visible = false;
            }
            this.label1.Text = dataInfo;
        }
    }
}
