using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BuscarPaciente().Show();
            this.Hide();
        }

        private void bttn_Agregar_Click(object sender, EventArgs e)
        {
            new AgregarPaciente().Show();
            this.Hide();
        }

        private void bttn_Eliminar_Click(object sender, EventArgs e)
        {
            new EliminarPaciente().Show();
            this.Hide();
        }
    }
}
