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
    public partial class Informacion : Form
    {

        IMC imcForm = new IMC();

        String[] informacion = new string[21];

        public Informacion()
        {
            InitializeComponent();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            informacion[0] = textBox1.Text;
            informacion[1] = textBox2.Text;
            informacion[2] = textBox3.Text;
            informacion[3] = textBox4.Text;
            informacion[4] = textBox5.Text;
            informacion[5] = textBox6.Text;
            informacion[6] = textBox7.Text;
            informacion[7] = textBox8.Text;
            informacion[8] = textBox9.Text;
            informacion[9] = textBox10.Text;
            informacion[10] = textBox11.Text;
            informacion[11] = textBox22.Text;
            informacion[12] = textBox21.Text;
            informacion[13] = textBox20.Text;
            informacion[14] = textBox19.Text;
            informacion[15] = textBox18.Text;
            informacion[16] = textBox17.Text;
            informacion[17] = textBox16.Text;
            informacion[18] = textBox15.Text;
            informacion[19] = textBox14.Text;
            informacion[20] = textBox13.Text;
            informacion[21] = textBox12.Text;
            Form1.datosPersonales.Add(informacion);
            MessageBox.Show("Información agregada");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imcForm.Show();
        }
    }
}
