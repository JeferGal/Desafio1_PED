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
    public partial class VerTodos : Form
    {

        public VerTodos()
        {
            InitializeComponent();
            CargarPacientesEnArbol();
        }

        private void CargarPacientesEnArbol()
        {
            try
            {

                Conexion objCon = new Conexion();
                MySqlConnection con = objCon.conexion;
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM paciente", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader["nombre"].ToString();
                    string expediente = reader["expediente"].ToString();
                    string genero = reader["genero"].ToString();
                    string tipoSangre = reader["tipo_sangre"].ToString();
                    string presionArterial = reader["presion"].ToString();

                    string nodoText = $"{nombre} ({expediente}) - Género: {genero}, Tipo de sangre: {tipoSangre}, Presión arterial: {presionArterial}";

                    TreeNode nodoPaciente = new TreeNode(nombre + " (" + expediente + ")");
                    nodoPaciente.Nodes.Add("Género: " + genero);
                    nodoPaciente.Nodes.Add("Tipo de sangre: " + tipoSangre);
                    nodoPaciente.Nodes.Add("Presión arterial: " + presionArterial);

                    treeViewPacientes.Nodes.Add(nodoPaciente);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}
