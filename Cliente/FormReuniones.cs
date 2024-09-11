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
    public partial class FormReuniones : Form
    {
        private int? usuarioId { get; set; }
        private List<Reunion>? reuniones;
        private List<Reunion>? reunioneslistadas;

        public FormReuniones()
        {
            InitializeComponent();
        }

        public FormReuniones(bool isAdmin, int? userId)
        {
            InitializeComponent();
            if (!isAdmin)
            {
                button1.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            usuarioId = userId;
        }

        private void button1_Click(object sender, EventArgs e) // crear nueva reunion
        {
            new DataReunion().ShowDialog();
            button5_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e) // ver detalles de una reunion
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                new DataReunionVer(reunioneslistadas[filaSeleccionada], usuarioId).ShowDialog();
                button5_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione una reunion para modificarla");
            }
        }

        private void button3_Click(object sender, EventArgs e) // editar una reunion
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                DateTime now = DateTime.Now;
                if (reunioneslistadas[filaSeleccionada].FechaHora > now || reunioneslistadas[filaSeleccionada].FechaHora == null)
                {
                    new DataReunion(reunioneslistadas[filaSeleccionada], usuarioId).ShowDialog();
                    button5_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No puede modificar una reunion con fecha pasada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reunion para modificarla");
            }
        }

        private async void button4_Click(object sender, EventArgs e) // eliminar una reunion
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                await ReunionNegocio.Delete(reunioneslistadas[filaSeleccionada]);
                button5_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione una reunion para eliminarla");
            }
        }

        private async void button5_Click(object sender, EventArgs e) //boton para listar
        {
            reuniones = await ReunionNegocio.GetAll();
            reunioneslistadas = reuniones;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reunioneslistadas;
        }

        private async void FormReuniones_Load_1(object sender, EventArgs e)
        {
            reuniones = await ReunionNegocio.GetAll();
            reunioneslistadas = reuniones;
            dataGridView1.DataSource = reunioneslistadas;
        }

        private async void button5_Click_1(object sender, EventArgs e)
        {
            if (reuniones != null)
            {
                List<Reunion> reusPendientes = new List<Reunion>();
                foreach (Reunion r in reuniones)
                {
                    IEnumerable<ReunionUsuario> reunionUsuarios = await ReunionUsuarioNegocio.GetbyReunion(r.Id);
                    ReunionUsuario? invitacion = reunionUsuarios.FirstOrDefault(ru => ru.UsuarioId == usuarioId);
                    if (invitacion != null && invitacion.Estado == "Pendiente")
                    {
                        reusPendientes.Add(r);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = reusPendientes;
                reunioneslistadas = reusPendientes;
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (reuniones != null)
            {
                List<Reunion> reusPendientes = new List<Reunion>();
                foreach (Reunion r in reuniones)
                {
                    IEnumerable<ReunionUsuario> reunionUsuarios = await ReunionUsuarioNegocio.GetbyReunion(r.Id);
                    ReunionUsuario? invitacion = reunionUsuarios.FirstOrDefault(ru => ru.UsuarioId == usuarioId);
                    if (invitacion != null && invitacion.Estado == "Aceptada")
                    {
                        reusPendientes.Add(r);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = reusPendientes;
                reunioneslistadas = reusPendientes;
            }

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (reuniones != null)
            {
                List<Reunion> reusPendientes = new List<Reunion>();
                foreach (Reunion r in reuniones)
                {
                    IEnumerable<ReunionUsuario> reunionUsuarios = await ReunionUsuarioNegocio.GetbyReunion(r.Id);
                    ReunionUsuario? invitacion = reunionUsuarios.FirstOrDefault(ru => ru.UsuarioId == usuarioId);
                    if (invitacion != null && invitacion.Estado == "Rechazada")
                    {
                        reusPendientes.Add(r);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = reusPendientes;
                reunioneslistadas = reusPendientes;
            }
        }
    }
}