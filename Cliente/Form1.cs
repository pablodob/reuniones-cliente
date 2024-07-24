using Negocio;
using Entidades;

namespace Cliente
{
    public partial class Form1 : Form
    {
        private Task<IEnumerable<Usuario>>? lista;

        public Form1()
        {
            InitializeComponent();
        }

        public IEnumerable<Usuario> cargarTabla()
        {
            lista = UsuarioNegocio.GetAll();
            return lista.Result;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<Usuario>> task = new Task<IEnumerable<Usuario>>(cargarTabla);
            task.Start();
            dataGridView1.DataSource = await task;
        }
    }
}
