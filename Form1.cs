using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        string Nombre, Apellido;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtNombre.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Limpiar manera rapida
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                    this.txtNombre.Focus();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            MessageBox.Show("Bienvenido:\n " + Nombre + " " + Apellido);
        }
    }
}
