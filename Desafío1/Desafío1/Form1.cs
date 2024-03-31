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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textUserName.Text;
            string Password = textPassword.Text;

            if (UserName == "usuario" && Password == "contraseña")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtalo de nuevo");
                textUserName.Clear();
                textPassword.Clear();
                textUserName.Focus();
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            textUserName.Clear();
            textPassword.Clear();
            textUserName.Focus();
        }
    }
}
