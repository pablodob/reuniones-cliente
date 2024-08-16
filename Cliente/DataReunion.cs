﻿using Entidades;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Cliente
{
    public partial class DataReunion : Form
    {
        List<Usuario> invitados = new List<Usuario>();
        Reunion reunion;
        int? usuarioId;

        public DataReunion()
        {
            InitializeComponent();
            CargarComboBox();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("NombreUsuario", "Usuario");
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            dateTimePicker1.Value = DateTime.Now;
        }

        public DataReunion(Reunion reunionAModificar, int? usuarioId)
        {
            InitializeComponent();
            button1.Text = "Editar";
            this.reunion = reunionAModificar;
            textBox1.Text = reunionAModificar.Titulo;
            textBox3.Text = reunionAModificar.Temas;
            if (reunionAModificar.FechaHora != null)
            {
                dateTimePicker1.Value = (DateTime)reunionAModificar.FechaHora;
            } else
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("NombreUsuario", "Usuario");
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            dataGridView1.Columns["Id"].DataPropertyName = "Id";

            CargarComboBox();
            this.usuarioId = usuarioId;
        }

        public IEnumerable<Usuario> cargarTabla()
        {
            return UsuarioNegocio.GetAll().Result;
        }

        private async void CargarComboBox()
        {
            Task<IEnumerable<Usuario>> task = new Task<IEnumerable<Usuario>>(cargarTabla);
            task.Start();
            comboBox1.DataSource = await task;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";

            comboBox3.DisplayMember = "NombreUsuario";
            comboBox3.ValueMember = "Id";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                MessageBox.Show("No puede crearse una reunion con fecha en el pasado");
            }
            else
            {
                Reunion a = new Reunion();
                a.Titulo = textBox1.Text;
                a.Temas = textBox3.Text;
                a.Estado = "Programada";
                a.FechaHora = dateTimePicker1.Value;
                a.CoordinadorId = ((Usuario)comboBox3.SelectedItem).Id;
                a = await ReunionNegocio.Add(a);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string IdString = row.Cells["Id"].Value.ToString();
                    int IdUser = Convert.ToInt32(IdString);
                    //Usuario user = await UsuarioNegocio.GetUser(IdUser);
                    ReunionUsuario ru = new ReunionUsuario();
                    ru.ReunionId = a.Id;
                    ru.UsuarioId = IdUser;
                    ru.Estado = "Invitado";
                    var ret = await ReunionUsuarioNegocio.Add(ru);
                }
                Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usuario invitado = (Usuario)comboBox1.SelectedItem;
            invitados.Add(invitado);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = invitados;

            comboBox3.DataSource = null;
            comboBox3.DataSource = invitados;
        }

        private async void DataReunion_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Usuario>? usuarios = await getUsuarios(reunion);

            dataGridView1.DataSource = usuarios;
            dataGridView1.Visible = true;

            comboBox3.DataSource = null;
            comboBox3.DataSource = invitados;
            comboBox3.SelectedItem = reunion.CoordinadorId;
        }

        private async Task<List<Usuario>>? getUsuarios(Reunion reunion)
        {
            var reunionUsuario = await ReunionUsuarioNegocio.GetbyReunion(reunion.Id);
            var usuarios = reunionUsuario.Select(ru => ru.Usuario).ToList();

            return usuarios;
        }
    }
}
