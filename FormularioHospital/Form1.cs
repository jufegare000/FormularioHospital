using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioHospital
{
    public partial class Form1 : Form
    {

        Registrar registrar = new Registrar();
        InicioSesion inicioSesion = new InicioSesion();
        Informacion informacion = new Informacion();

        public static List<String[]> usuarios = new List<string[]>();
        public static List<String[]> datosPersonales = new List<string[]>();


        public Form1()
        {
            usuarios.Add(new string[] { "admin", "root" });
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicioSesion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            informacion.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
