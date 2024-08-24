using Entidades;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class DataReunionVer : Form
    {
        int? usuarioId;
        Reunion reunion;
        ReunionUsuario? invitacion;

        public DataReunionVer(Reunion reunionAModificar, int? usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            reunion = reunionAModificar;
            label1.Text = reunionAModificar.Titulo;
            label3.Text = Convert.ToString(reunionAModificar.Id);
            label6.Text = reunionAModificar.Estado;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("NombreUsuario", "Usuario");
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            textBox2.Text = reunionAModificar.Minuta;
            label9.Text = reunionAModificar.Temas;
            label10.Text = reunionAModificar.FechaHora.ToString();

            if (reunionAModificar.Estado == "Programada")
            {
                textBox2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            if (usuarioId == reunionAModificar.CoordinadorId)
            {
                textBox2.Enabled = true;
            }
        }

        private async Task<List<Usuario>> getUsuarios(Reunion reunion)
        {
            List<ReunionUsuario> reunionUsuario = (List < ReunionUsuario > )await ReunionUsuarioNegocio.GetbyReunion(reunion.Id);
            List<Usuario> usuarios = new List<Usuario>();
            if (reunionUsuario != null && reunionUsuario.Count > 0)
            {
                invitacion = reunionUsuario.Where(ru => ru.UsuarioId == usuarioId).ToList()[0];
                if (invitacion.Estado != "Invitado")
                {
                    label12.Text = "Invitación Pendiete";
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
                else if (invitacion.Estado != "Aceptada")
                {
                    label12.Text = "Invitación Aceptada";
                }
                else if (invitacion.Estado != "Rechazada")
                {
                    label12.Text = "Invitación Rechazada";
                }
                usuarios = reunionUsuario.Select(ru => ru.Usuario).ToList();
            }

            return usuarios;
        }

        public IEnumerable<Usuario> cargarTabla()
        {
            return UsuarioNegocio.GetAll().Result;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Reunion a = new Reunion();
            a.Id = int.Parse(label3.Text);
            a.Titulo = label1.Text;
            a.Minuta = textBox2.Text;
            a.Temas = label9.Text;
            a.Estado = label6.Text;
            a.FechaHora = reunion.FechaHora;
            await ReunionNegocio.Update(a);

            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Realizada";
            textBox2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "Cancelada";
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = false;
            label12.Text = "Invitación rechazada";
            invitacion.Estado = "Rechazada";
            await ReunionUsuarioNegocio.Update(invitacion);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = false;
            label12.Text = "Invitación aceptada";
            invitacion.Estado = "Aceptada";
            await ReunionUsuarioNegocio.Update(invitacion);
        }

        private async void DataReunionVer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Usuario> usuarios = await getUsuarios(reunion);

            dataGridView1.DataSource = usuarios;
            dataGridView1.Visible = true;
        }

    }
}
