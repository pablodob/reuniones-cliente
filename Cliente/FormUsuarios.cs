using Negocio;
using Entidades;

namespace Cliente
{
    public partial class FormUsuarios : Form
    {
        private Task<IEnumerable<Usuario>>? usuarios;

        public FormUsuarios()
        {
            InitializeComponent();
            usuarios = UsuarioNegocio.GetAll();
        }

        public IEnumerable<Usuario> cargarTabla()
        {
            usuarios = UsuarioNegocio.GetAll();
            return usuarios.Result;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<Usuario>> task = new Task<IEnumerable<Usuario>>(cargarTabla);
            task.Start();
            dataGridView1.DataSource = await task;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new DataUsuario().ShowDialog();
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                new DataUsuario(usuarios.Result.ToList()[filaSeleccionada]).ShowDialog();
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para modificarlo");
            }
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                await UsuarioNegocio.Delete(usuarios.Result.ToList()[filaSeleccionada]);
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminarlo");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                new DataUsuario(usuarios.Result.ToList()[filaSeleccionada]).ShowDialog();
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para modificarlo");
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Task<IEnumerable<Usuario>> task = new Task<IEnumerable<Usuario>>(cargarTabla);
            task.Start();
            dataGridView1.DataSource = await task;
        }
    }
}