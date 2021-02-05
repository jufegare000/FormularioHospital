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
    public partial class InicioSesion : Form
    {

        String usuario;
        String contrasena;

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1.usuarios.ForEach(delegate (String[] usuarioRegistrado)
            {
                MessageBox.Show(usuarioRegistrado[0] + " " + usuarioRegistrado[1]);
            }
            );

            Boolean exists = true;
            usuario = textBox1.Text;
            contrasena = textBox2.Text;
            Form1.usuarios.ForEach(delegate(String[] usuarioRegistrado)
            {
                if(usuarioRegistrado[0].Equals(usuario) & usuarioRegistrado[1].Equals(contrasena))
                {
                    MessageBox.Show("Ha iniciado sesión");
                } else
                {
                    exists = false;
                }
            }
            );
            if (!exists)
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
