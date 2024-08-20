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

namespace Cliente
{
    public partial class Main : Form
    {
        private string? Token { get; set; }
        private int? userId { get; set; }
        private string? userName { get; set; }
        private bool isAdmin { get; set; }

        string securityKey = "LoshermanosseanunidosporqueesaeslaleyprimerA";
        public Main()
        {
            this.Token = Conexion.mytoken;
            InitializeComponent();

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            var principal = tokenHandler.ValidateToken(Token, tokenValidationParameters, out SecurityToken securityToken);

            // El payload del token está en principal.Claims
            userId = int.Parse(principal.FindFirst("usuarioId")?.Value);
            userName = principal.FindFirst("nombreUsuario")?.Value;
            string strisAdmin = principal.FindFirst("isAdmin")?.Value;
            if (strisAdmin == "1")
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

        private void botonUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios form1 = new FormUsuarios();
            form1.MdiParent = this;
            form1.Show();
        }

        private void botonReuniones_Click(object sender, EventArgs e)
        {
            FormReuniones formReuniones = new FormReuniones(isAdmin, userId);
            formReuniones.MdiParent = this;
            formReuniones.Show();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userId != null) { 
                InfoUser infouser = new InfoUser((int)userId, isAdmin);
                infouser.MdiParent = this;
                infouser.Show();
            }
        }
    }
}
