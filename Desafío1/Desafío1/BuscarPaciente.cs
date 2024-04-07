using Desafío1.Models;
using Desafío1.Tree;
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
    public partial class BuscarPaciente : Form
    {
        private ArbolPacientes arbol;
        

        public BuscarPaciente()
        {
            InitializeComponent();
            this.Load += BuscarPaciente_Load;
            arbol = new ArbolPacientes();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void BuscarPaciente_Load(object sender, EventArgs e)
        {
            txtExpediente.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numExpediente = txtExpediente.Text;

            if (string.IsNullOrWhiteSpace(numExpediente))
            {
                MessageBox.Show("Por favor ingrese un número de expediente para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Paciente pacienteEncontrado = arbol.BuscarPorNumeroExpediente(numExpediente);

            if (pacienteEncontrado != null)
            {
                MessageBox.Show($"Paciente encontrado: {pacienteEncontrado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró ningún paciente con ese número de expediente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
