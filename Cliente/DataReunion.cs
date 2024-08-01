using Entidades;
using Negocio;
using System;
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
        public DataReunion()
        {
            InitializeComponent();
        }

        public DataReunion(Reunion reunionAModificar)
        {
            InitializeComponent();
            button1.Text = "Editar";
            textBox1.Text = reunionAModificar.Titulo;
            label3.Text = Convert.ToString(reunionAModificar.Id);
            label6.Text = reunionAModificar.Estado;
            textBox2.Text = reunionAModificar.Minuta;
            textBox3.Text = reunionAModificar.Temas;
            if (reunionAModificar.Estado == "Programada")
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
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

        private async void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Realizada";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "Cancelada";
        }
    }
}
