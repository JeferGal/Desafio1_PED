using Desafío1.Models;
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
           
            try
            {
                Conexion objCon = new Conexion();
                MySqlConnection con = objCon.conexion;
                con.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM paciente WHERE expediente = @numExpediente", con);

                query.Parameters.AddWithValue("@numExpediente", numExpediente);

                using (MySqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Aquí puedes asignar los valores de las columnas a tus controles (labels, etc.)
                        lblEx.Text = "N° Expediene: " + reader["expediente"].ToString();
                        lblName.Text = "Nombre: " + reader["nombre"].ToString();
                        lblGenre.Text = "Género: " + reader["genero"].ToString();
                        lblTipo.Text = "Tipo de Sangre: " + reader["tipo_sangre"].ToString();
                        lblPresion.Text = "Presión Arterial: " + reader["presion"].ToString();

                        // Obtener los valores de género, tipo de sangre y presión arterial
                        string genero = reader["genero"].ToString();
                        string tipoSangre = reader["tipo_sangre"].ToString();
                        string presionArterial = reader["presion"].ToString();

                        // Asignar texto personalizado en lblRecomendacion según los valores
                        lblRecomendacion.Text = ObtenerRecomendacion(genero, tipoSangre, presionArterial);

                        txtExpediente.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún paciente con ese número de expediente.");
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
            }

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private string ObtenerRecomendacion(string genero, string tipoSangre, string presionArterial)
        {
            // Lógica para determinar el texto personalizado según género, tipo de sangre y presión arterial
            if (genero == "Masculino")
            {
                if (tipoSangre == "A")
                {
                    if (presionArterial == "Alta")
                        return "Recomendación: Evitar alimentos ricos en sodio y mantener un peso saludable. \nAdemás, es " +
                                "importante realizar ejercicio regularmente y seguir las recomendaciones \nmédicas para controlar la presión arterial.";
                    else if (presionArterial == "Normal")
                        return "Recomendación: Mantener una dieta balanceada, realizar actividad física regularmente y \nhacer chequeos médicos periódicos para monitorear la presión arterial.";
                    else if (presionArterial == "Baja")
                        return "Recomendación: Asegurarse de mantener una ingesta adecuada de líquidos y electrolitos, consumir comidas pequeñas \ny frecuentes, y evitar largos periodos de ayuno para evitar la hipotensión.";
                }
                else if (tipoSangre == "B")
                {
                    if (presionArterial == "Alta")
                        return "Recomendación: Reducir el consumo de alimentos procesados y grasas saturadas. \nSe recomienda seguir una dieta rica en " +
                            "frutas, verduras y granos enteros. " +
                            "\nAdemás, es crucial mantenerse físicamente activo y realizar chequeos médicos regulares para monitorear la presión arterial.";
                    else if (presionArterial == "Normal")
                        return "Recomendación: Seguir una dieta equilibrada, mantener un peso saludable y realizar ejercicio regularmente \npara mantener la presión arterial dentro de los rangos normales.";
                    else if (presionArterial == "Baja")
                        return "Recomendación: Consumir alimentos ricos en sodio de manera moderada, mantener una hidratación adecuada y \n evitar cambios bruscos de posición para ayudar a prevenir la hipotensión.";
                }
                else if (tipoSangre == "AB")
                {
                    if (presionArterial == "Alta")
                        return "Recomendación: Adoptar un estilo de vida saludable que incluya una dieta baja en sodio y alta en potasio. " +
                            "\nEs importante evitar el tabaco y el exceso de alcohol, además de realizar ejercicio regularmente. \nAdemás, es fundamental seguir las " +
                            "\nrecomendaciones médicas y tomar la medicación recetada para controlar la presión arterial";
                    else if (presionArterial == "Normal")
                        return "Recomendación: Mantener hábitos saludables, incluyendo una dieta balanceada y ejercicio regular, \npara mantener la presión arterial dentro de los niveles normales.";
                    else if (presionArterial == "Baja")
                        return "Recomendación: Consumir pequeñas comidas frecuentes, mantener una hidratación adecuada y evitar el \nalcohol y el tabaco para prevenir la hipotensión.";
                }
                else if (tipoSangre == "O")
                {
                    if (presionArterial == "Alta")
                        return "Recomendación: Enfocarse en una dieta equilibrada, rica en frutas, verduras, granos enteros y proteínas magras. " +
                            "\nLimitar el consumo de alimentos procesados y grasas saturadas es crucial. Además, es fundamental mantener un peso saludable, \nrealizar " +
                            "actividad física regularmente y seguir las indicaciones médicas para controlar la presión arterial.";
                    else if (presionArterial == "Normal")
                        return "Recomendación: Seguir una dieta rica en frutas, verduras y granos enteros, mantener un peso saludable y \nrealizar actividad física regular para mantener la presión arterial en niveles normales.";
                    else if (presionArterial == "Baja")
                        return "Recomendación: Consumir alimentos con alto contenido de sodio en moderación, mantener una hidratación adecuada y\n evitar el alcohol y el tabaco para evitar la hipotensión.";
                }
            }
            else if (genero == "Femenino")
            {
                if (tipoSangre == "A")
                {
                    if (presionArterial == "Alta")
                        return "Recomendación: Evitar alimentos ricos en sodio, mantener un peso saludable y realizar ejercicio regularmente.";
                    else if (presionArterial == "Normal")
                        return "Recomendación: Mantener una dieta balanceada, realizar actividad física regularmente y hacer chequeos médicos \nperiódicos para monitorear la presión arterial.";
                    else if (presionArterial == "Baja")
                        return "Recomendación: Asegurarse de mantener una ingesta adecuada de líquidos y electrolitos, consumir comidas pequeñas\n y frecuentes, y evitar largos periodos de ayuno para evitar la hipotensión.";
                }
                else if (tipoSangre == "B")
                {
                    if (presionArterial == "Alta")
                        return "Recomendación: Reducir consumo de alimentos procesados, seguir una dieta rica en frutas y verduras, y realizar actividad física regularmente.";
                    else if (presionArterial == "Normal")
                        return "Recomendación: Seguir una dieta equilibrada, mantener un peso saludable y realizar ejercicio regularmente para mantener la presión arterial \ndentro de los rangos normales.";
                    else if (presionArterial == "Baja")
                        return "Recomendación: Consumir alimentos ricos en sodio de manera moderada, mantener una hidratación adecuada y evitar cambios bruscos de posición \npara ayudar a prevenir la hipotensión.";
                }
                else if (tipoSangre == "AB")
                {
                    if (presionArterial == "Alta")
                        return "Recomendación: Adoptar un estilo de vida saludable, incluyendo una dieta baja en sodio, evitar el tabaco y el alcohol, y tomar medicación según\n las indicaciones médicas.";
                    else if (presionArterial == "Normal")
                        return "Recomendación: Mantener hábitos saludables, incluyendo una dieta balanceada y ejercicio regular, para mantener la presión arterial dentro de \nlos niveles normales.";
                    else if (presionArterial == "Baja")
                        return "Recomendación: Consumir pequeñas comidas frecuentes, mantener una hidratación adecuada y evitar el alcohol y el tabaco para prevenir la hipotensión.";
                }
                else if (tipoSangre == "O")
                {
                    if (presionArterial == "Alta")
                        return "Recomendación: Seguir una dieta equilibrada, mantener un peso saludable, realizar ejercicio regularmente y seguir las indicaciones\n médicas para controlar la presión arterial.";
                    else if (presionArterial == "Normal")
                        return "Recomendación: Seguir una dieta rica en frutas, verduras y granos enteros, mantener un peso saludable y realizar actividad física \nregular para mantener la presión arterial en niveles normales.";
                    else if (presionArterial == "Baja")
                        return "Recomendación: Consumir alimentos con alto contenido de sodio en moderación, mantener una hidratación adecuada y evitar el alcohol \ny el tabaco para evitar la hipotensión.";
                }
            }

            return "Texto de recomendación genérico para otros casos.";
        }
    }
}
