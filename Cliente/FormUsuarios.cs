using Negocio;
using Entidades;

namespace Cliente
{
    public partial class FormUsuarios : Form
    {
        private List<Usuario>? usuarios;

        public FormUsuarios()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("NombreUsuario", "Usuario");
            dataGridView1.Columns.Add("Role", "Role");
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            dataGridView1.Columns["Role"].DataPropertyName = "Role";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            usuarios = (List<Usuario>)await UsuarioNegocio.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuarios;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                Usuario u = usuarios[filaSeleccionada];
                if (u.Role == 1)
                {
                    u.Password = null;
                    u.Role = 0;
                    await UsuarioNegocio.Update(u);
                    button1_Click(sender, e);
                }
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
                await UsuarioNegocio.Delete(usuarios[filaSeleccionada]);
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminarlo");
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            usuarios = (List<Usuario>)await UsuarioNegocio.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usuarios;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //verifica que haya una fila seleccionada
            {
                Usuario myUser = await UsuarioNegocio.GetMyUser();
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                Usuario u = usuarios[filaSeleccionada];
                if (u.Role == 0 && u.Id != myUser.Id)
                {
                    u.Password = null;
                    u.Role = 1;
                    await UsuarioNegocio.Update(u);
                    button1_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para modificarlo");
            }
        }
    }
}