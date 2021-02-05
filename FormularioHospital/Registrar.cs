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
    public partial class Registrar : Form
    {
        String usuario;
        String contrasena;

        public Registrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = textBox1.Text;
            contrasena = textBox2.Text;
            List<String[]> usuarios = Form1.usuarios;
            usuarios.Append(new string[] { usuario, contrasena });
            Form1.usuarios = usuarios;

            MessageBox.Show("Información agregada");

            Form1.usuarios.ForEach(delegate (String[] usuarioRegistrado)
            {
                MessageBox.Show(usuarioRegistrado[0] + " " + usuarioRegistrado[1]);
            }
            );
        }
    }
}
