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
using static Desafío1.Enum.EnumGenero;
using static Desafío1.Enum.EnumPresion;
using static Desafío1.Enum.EnumTipoSangre;

namespace Desafío1
{
    public partial class AgregarPaciente : Form
    {

        private ArbolPacientes arbol;

        public AgregarPaciente()
        {
            InitializeComponent();
            arbol = new ArbolPacientes();

            this.StartPosition = FormStartPosition.CenterScreen;
            cmbGenero.Items.Add(Genero.Masculino);
            cmbGenero.Items.Add(Genero.Femenino);
            // Agregar elementos al ComboBox de tipo sanguíneo
            cmbSangre.Items.Add(TipoSangre.A);
            cmbSangre.Items.Add(TipoSangre.B);
            cmbSangre.Items.Add(TipoSangre.AB);
            cmbSangre.Items.Add(TipoSangre.O);

            // Agregar elementos al ComboBox de presión arterial
            cmbPresion.Items.Add(PresionArterial.Baja);
            cmbPresion.Items.Add(PresionArterial.Media);
            cmbPresion.Items.Add(PresionArterial.Alta);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {

                // Verificar si los campos están vacíos
                if (string.IsNullOrWhiteSpace(txtExpediente.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    cmbGenero.SelectedItem == null ||
                    cmbSangre.SelectedItem == null ||
                    cmbPresion.SelectedItem == null)
                {
                    throw new ArgumentException("Por favor complete todos los campos.");
                }

                // Obtener datos del formulario
                string numeroExpediente = txtExpediente.Text;
                string nombre = txtNombre.Text;

                Genero genero = (Genero)cmbGenero.SelectedItem;
                TipoSangre tipoSangre = (TipoSangre)cmbSangre.SelectedItem;
                PresionArterial presionArterial = (PresionArterial)cmbPresion.SelectedItem;


                Paciente nuevoPaciente = new Paciente(numeroExpediente, nombre, genero, tipoSangre, presionArterial);
                arbol.Insertar(nuevoPaciente);

                ActualizarListaPacientes();

                txtExpediente.Clear();
                txtNombre.Text = "";
                cmbGenero.SelectedIndex = -1; // Esto establece el índice seleccionado en ninguno
                cmbSangre.SelectedIndex = -1;
                cmbPresion.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
        private void ActualizarListaPacientes()
        {
            //lstPacientes.Items.Clear();
            arbol.MostrarPacientes();
        }

    }
}
