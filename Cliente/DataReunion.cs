using Entidades;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class DataReunion : Form
    {
        List<Usuario> invitados = new List<Usuario>();


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
        }

        public DataReunion(Reunion reunionAModificar)
        {
            InitializeComponent();
            button1.Text = "Editar";
            textBox1.Text = reunionAModificar.Titulo;
            label3.Text = Convert.ToString(reunionAModificar.Id);
            label6.Text = reunionAModificar.Estado;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("NombreUsuario", "Usuario");
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            dataGridView1.Columns["Id"].DataPropertyName = "Id";
            if (reunionAModificar.Estado == "Programada")
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
            CargarComboBox();
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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Reunion a = new Reunion();
            a.Titulo = textBox1.Text;
            if (button1.Text == "Editar")
            {
                a.Id = Convert.ToInt32(label3.Text);
                a.Estado = label6.Text;
                await ReunionNegocio.Update(a);
            }
            else
            {
                a.Estado = "Programada";
                await ReunionNegocio.Add(a);
            }

            /*foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string IdString = row.Cells["Id"].Value.ToString();
                long IdUser = Convert.ToInt32(IdString);
                Usuario user = await UsuarioNegocio.GetUser(IdUser);
                ReunionUsuario ru = new ReunionUsuario();
                ru.ReunionId = a;
                ru.UsuarioId = user;
                ru.Estado = "Invitado";
                await ReunionUsuarioNegocio.Add(ru);
            }*/
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Realizada";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "Cancelada";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usuario invitado = (Usuario)comboBox1.SelectedItem;
            //MessageBox.Show("El usuario de nombre " + invitado.Nombre + " sera invitado a la reunion");
            invitados.Add(invitado);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = invitados;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = invitados;
        }

    }
}
