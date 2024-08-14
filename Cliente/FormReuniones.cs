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
        private Task<IEnumerable<Reunion>>? lista;

        public FormReuniones()
        {
            InitializeComponent();
        }

        public FormReuniones(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
            {
                button1.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }

        public IEnumerable<Reunion> cargarTabla()
        {
            lista = ReunionNegocio.GetAll();
            return lista.Result;
        }

        private void button1_Click(object sender, EventArgs e) // crear nueva reunion
        {
            new DataReunion().ShowDialog();
            button5_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e) // ver detalles de una reunion
        {

        }

        private void button3_Click(object sender, EventArgs e) // editar una reunion
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                new DataReunion(lista.Result.ToList()[filaSeleccionada]).ShowDialog();
                button5_Click(sender, e);
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
                await ReunionNegocio.Delete(lista.Result.ToList()[filaSeleccionada]);
                button5_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione una reunion para eliminarla");
            }
        }

        private async void button5_Click(object sender, EventArgs e) //boton para listar
        {
            Task<IEnumerable<Reunion>> task = new Task<IEnumerable<Reunion>>(cargarTabla);
            task.Start();
            dataGridView1.DataSource = await task;
        }
        private async void FormReuniones_Load_1(object sender, EventArgs e)
        {
            Task<IEnumerable<Reunion>> task = new Task<IEnumerable<Reunion>>(cargarTabla);
            task.Start();
            dataGridView1.DataSource = await task;
        }

    }
}