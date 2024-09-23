using Entidades;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace Cliente
{
    public partial class DataReunionVer : Form
    {
        int? usuarioId;
        Reunion reunion;
        ReunionUsuario? invitacion;
        List<Texto> textos = new List<Texto>();
        List<Usuario> invitados = new List<Usuario>();
        List<Usuario> invitadosAceptados = new List<Usuario>();
        Usuario? usuario;

        public DataReunionVer(Reunion reunionAModificar, int? usuarioId)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            reunion = reunionAModificar;

            label1.Text = reunionAModificar.Titulo;
            label3.Text = Convert.ToString(reunionAModificar.Id);
            label6.Text = reunionAModificar.Estado;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("NombreUsuario", "Usuario");
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            dataGridView1.Columns["Id"].DataPropertyName = "Id";

            textBox2.Text = reunionAModificar.Minuta;
            label9.Text = reunionAModificar.Temas;
            label10.Text = reunionAModificar.FechaHora.ToString();
            if (reunionAModificar.Coordinador != null && reunionAModificar.Coordinador.Nombre != null)
            {
                label15.Text = reunionAModificar.Coordinador.Nombre;
            }

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Add("Titulo", "Titulo");
            dataGridView2.Columns.Add("Link", "Link");
            dataGridView2.Columns.Add("Obligatorio", "Obligatorio");
            dataGridView2.Columns["Titulo"].DataPropertyName = "Titulo";
            dataGridView2.Columns["Link"].DataPropertyName = "Link";
            dataGridView2.Columns["Obligatorio"].DataPropertyName = "Obligatorio";
            dataGridView2.DataSource = textos;

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.Columns.Add("Nombre", "Nombre");
            dataGridView3.Columns.Add("NombreUsuario", "Usuario");
            dataGridView3.Columns.Add("Id", "Id");
            dataGridView3.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView3.Columns["NombreUsuario"].DataPropertyName = "NombreUsuario";
            dataGridView3.Columns["Id"].DataPropertyName = "Id";
        }

        private async Task<List<Usuario>> getUsuarios(Reunion reunion)
        {
            List<ReunionUsuario> reunionUsuario = (List<ReunionUsuario>)await ReunionUsuarioNegocio.GetbyReunion(reunion.Id);
            List<Usuario> usuarios = new List<Usuario>();
            if (reunionUsuario != null && reunionUsuario.Count > 0)
            {
                usuarios = reunionUsuario.Select(ru => ru.Usuario).ToList();
            }

            return usuarios;
        }

        private async Task<List<Usuario>> getAceptados(Reunion reunion)
        {
            List<ReunionUsuario> reunionUsuario = (List<ReunionUsuario>)await ReunionUsuarioNegocio.GetbyReunion(reunion.Id);
            List<Usuario> usuarios = new List<Usuario>();
            if (reunionUsuario != null && reunionUsuario.Count > 0)
            {
                usuarios = reunionUsuario.Where(ru => ru.Estado == "Aceptada").Select(ru => ru.Usuario).ToList();
            }

            return usuarios;
        }

        public IEnumerable<Usuario> cargarTabla()
        {
            return UsuarioNegocio.GetAll().Result;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Las memorias aún no han sido guardadas");
            }
            else
            {
                Reunion a = reunion;
                a.Minuta = textBox2.Text;
                a.Estado = label6.Text; //
                await ReunionNegocio.Update(a);
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
            textBox2.Enabled = true;
            
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar la reunión? Esta acción es irreversible.", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                reunion.Estado = "Cancelada";
                await ReunionNegocio.Update(reunion);

                Dispose();
            }

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea rechazar la invitacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                button5.Enabled = false;
                button6.Enabled = false;
                label12.Text = "Invitación rechazada";
                invitacion.Estado = "Rechazada";
                await ReunionUsuarioNegocio.Update(invitacion);
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = false;
            label12.Text = "Invitación aceptada";
            invitacion.Estado = "Aceptada";
            await ReunionUsuarioNegocio.Update(invitacion);
        }

        private async void DataReunionVer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            invitados = await getUsuarios(reunion);
            invitadosAceptados = await getAceptados(reunion);

            dataGridView1.DataSource = invitados;
            dataGridView1.Visible = true;

            dataGridView3.DataSource = invitados;
            dataGridView3.Visible = true;

            textos = await TextoNegocio.GetbyReunionId(reunion.Id);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = textos;

            IEnumerable<ReunionUsuario> reunionUsuarios = await ReunionUsuarioNegocio.GetbyReunion(reunion.Id);
            invitacion = reunionUsuarios.FirstOrDefault(ru => ru.UsuarioId == usuarioId);
            if (invitacion == null)
            {
                button5.Enabled = false;
                button6.Enabled = false;
            }
            else
            {
                if (invitacion.Estado == "Pendiente")
                {
                    label12.Text = "Invitación Pendiente";
                }
                else if (invitacion.Estado == "Aceptada")
                {
                    label12.Text = "Invitación Aceptada";
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
                else if (invitacion.Estado == "Rechazada")
                {
                    label12.Text = "Invitación Rechazada";
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
            }

            if (usuarioId != null)
            {
                usuario = await UsuarioNegocio.GetMyUser();
                if (usuario.Role == 0 || usuarioId == reunion.CoordinadorId)
                {
                    if (reunion.Estado == "Programada")
                    {
                        button3.Enabled = true;
                        button4.Enabled = true;
                    }
                    if (usuarioId == reunion.CoordinadorId && reunion.Estado == "Realizada")
                    {
                        textBox2.Enabled = true;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (reunion != null && reunion.Minuta != null)
            {
                // Create a new PDF document
                PdfDocument document = new PdfDocument();

                // Create an empty page
                PdfPage page = document.AddPage();

                // Get an XGraphics object for drawing
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Create a font
                XFont fontTitle = new XFont("Verdana", 20);
                XFont fontText = new XFont("Verdana", 12);

                double y = 40; // Start at the top of the page

                gfx.DrawString("Título:" + reunion.Titulo, fontTitle, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopCenter);
                y += 50;
                gfx.DrawString("Fecha y hora:" + reunion.FechaHora.ToString(), fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                y += 25;
                gfx.DrawString("Estado:" + reunion.Estado, fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                y += 25;
                gfx.DrawString("Temas:" + reunion.Temas, fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                y += 25;
                gfx.DrawString("Invitados:", fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                foreach (Usuario inv in invitados)
                {
                    y += 18;
                    gfx.DrawString("* Nombre: " + inv.Nombre + " | Usuario: " + inv.NombreUsuario, fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                }
                y += 25;
                gfx.DrawString("Textos:", fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                foreach (Texto tex in textos)
                {
                    y += 18;
                    gfx.DrawString("* " + tex.Titulo + " | Link: " + tex.Link, fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                }
                y += 25;
                gfx.DrawString("Minuta:", fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                y += 18;
                gfx.DrawString(reunion.Minuta, fontText, XBrushes.Black, new XRect(0, y, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                // Save the document...
                string filename = reunion.Titulo.Replace(" ", "") + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";

                document.Save(filename);
                // ...and start a viewer.
                string pdfViewerPath = @"C:\Program Files\Adobe\Acrobat DC\Acrobat\Acrobat.exe";
                Process.Start(pdfViewerPath, filename);
                //Process.Start(filename);
            }
            else
            {
                MessageBox.Show("La reunión debe tener minuta para emitir el informe");
            }
        }

    }
}
