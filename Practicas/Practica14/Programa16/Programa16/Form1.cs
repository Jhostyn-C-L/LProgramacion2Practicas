using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa16
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            operacion = "+";
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            operacion = "-";
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            operacion = "*";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            operacion = "/";
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double numero2 = Convert.ToDouble(textBox1.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        return;
                    }
                    break;
            }

            textBox1.Text = resultado.ToString();
    }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numero1 = 0;
            operacion = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }
    }
}
