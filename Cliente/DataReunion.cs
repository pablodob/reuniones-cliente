using Entidades;
using Microsoft.VisualBasic.ApplicationServices;
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
        List<Texto> textos = new List<Texto>();
        List<Texto> newtextos = new List<Texto>();
        Reunion reunion;
        int? usuarioId;
        List<ReunionUsuario> oldInvitaciones = new List<ReunionUsuario>();

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

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Add("Titulo", "Titulo");
            dataGridView2.Columns.Add("Link", "Link");
            dataGridView2.Columns.Add("Obligatorio", "Obligatorio");
            dataGridView2.Columns["Titulo"].DataPropertyName = "Titulo";
            dataGridView2.Columns["Link"].DataPropertyName = "Link";
            dataGridView2.Columns["Obligatorio"].DataPropertyName = "Obligatorio";
            dataGridView2.DataSource = textos;
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
            }
            else
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

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Add("Titulo", "Titulo");
            dataGridView2.Columns.Add("Link", "Link");
            dataGridView2.Columns.Add("Obligatorio", "Obligatorio");
            dataGridView2.Columns["Titulo"].DataPropertyName = "Titulo";
            dataGridView2.Columns["Link"].DataPropertyName = "Link";
            dataGridView2.Columns["Obligatorio"].DataPropertyName = "Obligatorio";
            dataGridView2.DataSource = textos;
            button5.Enabled = false;
            
            if (reunionAModificar.CoordinadorId != null) {
                CargarComboBox((int) reunionAModificar.CoordinadorId);
            }
            cargarTextos(reunionAModificar.Id);
            this.usuarioId = usuarioId;
        }

        public IEnumerable<Usuario> cargarTabla()
        {
            return UsuarioNegocio.GetAll().Result;
        }

        private async void cargarTextos(int reunionId)
        {
            textos = await TextoNegocio.GetbyReunionId(reunionId);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = textos;

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

        private async void CargarComboBox(int coorindadorId)
        {
            Task<IEnumerable<Usuario>> task = new Task<IEnumerable<Usuario>>(cargarTabla);
            task.Start();

            comboBox1.DataSource = await task;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";

            comboBox3.DisplayMember = "NombreUsuario";
            comboBox3.ValueMember = "Id";

            comboBox3.SelectedIndex = comboBox1.FindString(coorindadorId.ToString());
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            bool faltanDatos = false;
            if (textBox1.Text == "")
            {
                label1.ForeColor = Color.Red;
                faltanDatos = true;
            }
            if (textBox3.Text == "")
            {
                label8.ForeColor = Color.Red;
                faltanDatos = true;
            }
            if (dataGridView1.Rows.Count == 0)
            {
                label7.ForeColor = Color.Red;
                faltanDatos = true;
            }
            if (comboBox3.SelectedIndex == -1)
            {
                label2.ForeColor = Color.Red;
                faltanDatos = true;
            }

            if (faltanDatos)
            {
                MessageBox.Show("Faltan datos obligatorios", "Error", MessageBoxButtons.OK);
            }
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                MessageBox.Show("No puede crearse o editarse una reunion con fecha en el pasado", "Error",MessageBoxButtons.OK);
                faltanDatos = true;
            }
            if (faltanDatos == false)
            {
                if (button1.Text == "Editar")
                {
                    Reunion a = reunion;
                    a.Titulo = textBox1.Text;
                    a.Temas = textBox3.Text;
                    a.FechaHora = dateTimePicker1.Value;
                    a.CoordinadorId = ((Usuario)comboBox3.SelectedItem).Id;

                    await ReunionNegocio.Update(a);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string IdString = row.Cells["Id"].Value.ToString();
                        int IdUser = Convert.ToInt32(IdString);
                        if (oldInvitaciones.Where(x => x.UsuarioId == IdUser && x.ReunionId == reunion.Id).ToList().Count() == 0)
                        {
                            ReunionUsuario ru = new ReunionUsuario();
                            ru.ReunionId = reunion.Id;
                            ru.UsuarioId = IdUser;
                            ru.Estado = "Enviada";
                            var ret = await ReunionUsuarioNegocio.Add(ru);
                        }
                    }
                    foreach (Texto text in newtextos)
                    {
                        text.ReunionId = a.Id;
                        var rettext = await TextoNegocio.Add(text);
                    }

                }
                else
                {
                    Reunion a = new Reunion();
                    a.Titulo = textBox1.Text;
                    a.Temas = textBox3.Text;
                    a.Estado = "Programada";
                    a.FechaHora = dateTimePicker1.Value;
                    a.CoordinadorId = ((Usuario)comboBox3.SelectedItem).Id;
                    Reunion? res = await ReunionNegocio.Add(a);

                    if (res != null)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            string IdString = row.Cells["Id"].Value.ToString();
                            int IdUser = Convert.ToInt32(IdString);
                            //Usuario user = await UsuarioNegocio.GetUser(IdUser);
                            ReunionUsuario ru = new ReunionUsuario();
                            ru.ReunionId = res.Id;
                            ru.UsuarioId = IdUser;
                            ru.Estado = "Enviada";
                            var ret = await ReunionUsuarioNegocio.Add(ru);
                        }

                        foreach (Texto text in newtextos)
                        {
                            text.ReunionId = res.Id;
                            var rettext = await TextoNegocio.Add(text);
                        }
                    }
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
            comboBox3.DataSource = null;
            comboBox3.DataSource = invitados;

            dataGridView1.Visible = true;
            dataGridView1.DataSource = null;

            if (reunion != null)
            {
                List<Usuario>? usuarios = await getUsuarios(reunion);
                dataGridView1.DataSource = usuarios;
                comboBox3.SelectedItem = reunion.CoordinadorId;
            }
        }

        private async Task<List<Usuario>>? getUsuarios(Reunion reunion)
        {
            var reunionUsuario = await ReunionUsuarioNegocio.GetbyReunion(reunion.Id);
            oldInvitaciones = reunionUsuario.ToList();
            var usuarios = reunionUsuario.Select(ru => ru.Usuario).ToList();

            return usuarios;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Texto text = new Texto();
            text.Titulo = textBox2.Text;
            text.Link = textBox4.Text;
            text.Obligatorio = checkBox1.Checked;
            textos.Add(text);
            newtextos.Add(text);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = textos;
            textBox2.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = false;
        }
    }
}
