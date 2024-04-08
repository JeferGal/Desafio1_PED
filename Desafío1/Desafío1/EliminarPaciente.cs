using Desafío1.Tree;
using MySql.Data.MySqlClient;
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
        //private ArbolPacientes arbol;

        public EliminarPaciente()
        {
            InitializeComponent();
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

            //Cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este paciente?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                // El usuario ha confirmado la eliminación
                try
                {
                    Conexion objCon = new Conexion();
                    MySqlConnection con = objCon.conexion;
                    con.Open(); 

                    MySqlCommand query = new MySqlCommand("DELETE FROM paciente WHERE expediente = @num", con);
                    query.Parameters.AddWithValue("@num", num);

                    int rowsAffected = query.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("El paciente con número de expediente " + num + " ha sido eliminado correctamente.");
                        txtExpediente.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún paciente con ese número de expediente.");
                    }

                    con.Close(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el paciente, error: " + ex.ToString());
                }
            }
            else
            {
                //Operación cancelada
                MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
