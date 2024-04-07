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
    public partial class EliminarPaciente : Form
    {
        private ArbolPacientes arbol;

        public EliminarPaciente()
        {
            InitializeComponent();
            arbol = new ArbolPacientes();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string num = txtExpediente.Text;

            if (string.IsNullOrWhiteSpace(num))
            {
                MessageBox.Show("Por favor ingrese un número de expediente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            arbol.EliminarPorNumeroExpediente(num);
            ActualizarListaPacientes();
            // Mostrar un mensaje indicando si la eliminación fue exitosa
            MessageBox.Show("El paciente ha sido eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarListaPacientes()
        {
            //lstPacientes.Items.Clear();
            Console.WriteLine("\n Pacientes que quedan, después de eliminar: \n");
            arbol.MostrarPacientes();
        }
    }
}
