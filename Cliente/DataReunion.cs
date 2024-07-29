using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Reunion a = new Reunion();
            a.Titulo = textBox1.Text;
            //a.Id = textBox2.Text;
            if (button1.Text == "Editar")
            {
                a.Id = Convert.ToInt32(label3.Text);
                await ReunionNegocio.Update(a); 
            }
            else { await ReunionNegocio.Add(a); }
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
