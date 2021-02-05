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
    public partial class IMC : Form
    {

        string masa;
        string estatura;
        string peso;
        string edad;

        int numeroIdentidad;
        string tipoIdentidad;

        public IMC()
        {
            InitializeComponent();
        }

        public IMC(int numeroIdentidad, string tipoIdentidad)
        {
            this.numeroIdentidad = numeroIdentidad;
            this.tipoIdentidad = tipoIdentidad;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masa = textBox1.Text;
            estatura = textBox2.Text;
            string clasificacion = "";
            double masaDouble = Double.Parse(masa);
            double estaturaDouble = Double.Parse(estatura);
            double imc = masaDouble / (estaturaDouble * estaturaDouble);

            if (imc < 16)
                clasificacion = "Infrapeso, delgadez severa";
            else if (imc >= 16 & imc < 17)
                clasificacion = "Infrapeso, delgadez moderada";
            else if (imc >= 17 & imc < 18.5)
                clasificacion = "Infrapeso, delgadez aceptable";
            else if (imc >= 18.5 & imc < 25)
                clasificacion = "Peso normal";
            else if (imc >= 25 & imc < 30)
                clasificacion = "Sobrepeso";
            else if (imc >= 30 & imc < 35)
                clasificacion = "Obeso tipo I";
            else if (imc >= 35 & imc < 40)
                clasificacion = "Obeso tipo II";
            else
                clasificacion = "Obeso tipo III";
            MessageBox.Show(imc.ToString() + " es el IMC y su clasificación es "+ clasificacion);
        }

        private void IMC_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            peso = textBox4.Text;
            estatura = textBox3.Text;
            edad = textBox5.Text;
            double pesoDouble = Double.Parse(peso);
            double estaturaDouble = Double.Parse(estatura);
            double edadDouble = Double.Parse(edad);
            double imch = (10*pesoDouble) + (6.25*estaturaDouble) - (5*edadDouble) - 161;
            MessageBox.Show(imch.ToString() + " es el IMCM");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            peso = textBox4.Text;
            estatura = textBox3.Text;
            edad = textBox5.Text;
            double pesoDouble = Double.Parse(peso);
            double estaturaDouble = Double.Parse(estatura);
            double edadDouble = Double.Parse(edad);
            double imch = (10 * pesoDouble) + (6.25 * estaturaDouble) - (5 * edadDouble) + 5;
            MessageBox.Show(imch.ToString() + " es el IMCH");
        }
    }
}
