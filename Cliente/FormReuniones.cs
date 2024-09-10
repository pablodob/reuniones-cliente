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
        private Task<List<Reunion>>? reuniones;

        public FormReuniones()
        {
            InitializeComponent();
            reuniones = ReunionNegocio.GetAll();
        }

        public FormReuniones(bool isAdmin, int? userId)
        {
            InitializeComponent();
            reuniones = ReunionNegocio.GetAll();
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
                new DataReunionVer(reuniones.Result.ToList()[filaSeleccionada], usuarioId).ShowDialog();
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
                if (reuniones.Result.ToList()[filaSeleccionada].FechaHora > now || reuniones.Result.ToList()[filaSeleccionada].FechaHora == null)
                {
                    new DataReunion(reuniones.Result.ToList()[filaSeleccionada], usuarioId).ShowDialog();
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
                await ReunionNegocio.Delete(reuniones.Result.ToList()[filaSeleccionada]);
                button5_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione una reunion para eliminarla");
            }
        }

        private async void button5_Click(object sender, EventArgs e) //boton para listar
        {
            List<Reunion> reus = await ReunionNegocio.GetAll();
            dataGridView1.DataSource = reus;
        }

        private async void FormReuniones_Load_1(object sender, EventArgs e)
        {
            List<Reunion> reus = await ReunionNegocio.GetAll();
            dataGridView1.DataSource = reus;
        }

        private async void button5_Click_1(object sender, EventArgs e)
        {
            if (reuniones != null)
            {
                List<Reunion> reus = await reuniones;
                List<Reunion> reusPendientes = new List<Reunion>();
                foreach (Reunion r in reus)
                {
                    IEnumerable<ReunionUsuario> reunionUsuarios = await ReunionUsuarioNegocio.GetbyReunion(r.Id);
                    ReunionUsuario? invitacion = reunionUsuarios.FirstOrDefault();
                    if (invitacion != null && invitacion.Estado == "Pendiente")
                    {
                        reusPendientes.Add(r);
                    }
                }
                dataGridView1.DataSource = reusPendientes;
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (reuniones != null)
            {
                List<Reunion> reus = await reuniones;
                List<Reunion> reusPendientes = new List<Reunion>();
                foreach (Reunion r in reus)
                {
                    IEnumerable<ReunionUsuario> reunionUsuarios = await ReunionUsuarioNegocio.GetbyReunion(r.Id);
                    ReunionUsuario? invitacion = reunionUsuarios.FirstOrDefault();
                    if (invitacion != null && invitacion.Estado == "Aceptada")
                    {
                        reusPendientes.Add(r);
                    }
                }
                dataGridView1.DataSource = reusPendientes;
            }

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (reuniones != null)
            {
                List<Reunion> reus = await reuniones;
                List<Reunion> reusPendientes = new List<Reunion>();
                foreach (Reunion r in reus)
                {
                    IEnumerable<ReunionUsuario> reunionUsuarios = await ReunionUsuarioNegocio.GetbyReunion(r.Id);
                    ReunionUsuario? invitacion = reunionUsuarios.FirstOrDefault();
                    if (invitacion != null && invitacion.Estado == "Rechazada")
                    {
                        reusPendientes.Add(r);
                    }
                }
                dataGridView1.DataSource = reusPendientes;
            }

        }
    }
}