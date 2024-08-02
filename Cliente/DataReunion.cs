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
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
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
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            textBox2.Text = reunionAModificar.Minuta;
            textBox3.Text = reunionAModificar.Temas;
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
            a.Minuta = textBox2.Text;
            a.Temas = textBox3.Text;
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

        /*public IEnumerable<Reunion> cargarInvitados()
        {
            lista = ReunionNegocio.GetAll();
            return lista.Result;
        }*/

        private void button5_Click(object sender, EventArgs e)
        {
            Usuario invitado = (Usuario)comboBox1.SelectedItem;
            MessageBox.Show("El usuario de nombre " + invitado.Nombre + " sera invitado a la reunion");
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
