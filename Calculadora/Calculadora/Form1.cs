using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double Valor1;
        private double Valor2;
        private double Resultado;
        private int Operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCero_Click(object sender, EventArgs e)
        {
            //numero 0
            TbDisplay.Text = TbDisplay.Text + "0";
            TbDisplayMini.Text += "0";
        }

        private void BtnUno_Click(object sender, EventArgs e)
        {
            //numero 1
            TbDisplay.Text = TbDisplay.Text + "1";
            TbDisplayMini.Text += "1";
        }

        private void BtnDos_Click(object sender, EventArgs e)
        {
            //numero 2
            TbDisplay.Text = TbDisplay.Text + "2";
            TbDisplayMini.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            //numero 3
            TbDisplay.Text = TbDisplay.Text + "3";
            TbDisplayMini.Text += "3";
        }

        private void BtnCuatro_Click(object sender, EventArgs e)
        {
            //numero 4
            TbDisplay.Text = TbDisplay.Text + "4";
            TbDisplayMini.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            //numero 5
            TbDisplay.Text = TbDisplay.Text + "5";
            TbDisplayMini.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            //numero 6
            TbDisplay.Text = TbDisplay.Text + "6";
            TbDisplayMini.Text += "6";

        }

        private void BtnSiete_Click(object sender, EventArgs e)
        {
            //numero 7
            TbDisplay.Text = TbDisplay.Text + "7";
            TbDisplayMini.Text += "7";
        }

        private void BtnOcho_Click(object sender, EventArgs e)
        {
            //numero 8
            TbDisplay.Text = TbDisplay.Text + "8";
            TbDisplayMini.Text += "8";
        }

        private void BtnNueve_Click(object sender, EventArgs e)
        {
            //numero 9
            TbDisplay.Text = TbDisplay.Text + "9";
            TbDisplayMini.Text += "9";
        }

        private void TbDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnPunto_Click(object sender, EventArgs e)
        {
            //boton punto
            TbDisplay.Text = TbDisplay.Text + ".";
            TbDisplayMini.Text += ".";
            if (TbDisplayMini.Text == ".." && TbDisplay.Text == "..")
            {
                TbDisplay.Text = "Error";
                TbDisplayMini.Text = "Error";
            }
        }

        private void BtnPosandNeg_Click(object sender, EventArgs e)
        {
            if (TbDisplay.Text != "") // Verifica que el TextBox no esté vacío
            {
                double numero = Convert.ToDouble(TbDisplay.Text);
                numero *= -1; // Multiplica el número por -1 para cambiar el signo
                TbDisplay.Text = numero.ToString();
                TbDisplayMini.Text = numero.ToString();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //boton limpiar
            TbDisplay.Text = "";
            TbDisplayMini.Text = " ";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            //boton igual
            
            switch(Operacion)
            {
                case 1:
                    {
                        
                        Valor2 = Convert.ToDouble(TbDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
                        TbDisplayMini.Text = $"{Valor1} + {Valor2 }";
                        Resultado = Valor1 + Valor2;
                        TbDisplay.Text = Resultado.ToString();
                        TbDisplayMini.Text = $"{Valor1} + {Valor2 } ={Resultado}";
                        break;
                    }
                case 2:
                    {
                        Valor2 = Convert.ToDouble(TbDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
                        TbDisplayMini.Text = $"{Valor1} - {Valor2 }";
                        Resultado = Valor1 - Valor2;
                        TbDisplay.Text = Resultado.ToString();
                        TbDisplayMini.Text = $"{Valor1} - {Valor2 } ={Resultado}";
                        break;
                    }
                case 3:
                    {
                        Valor2 = Convert.ToDouble(TbDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
                        TbDisplayMini.Text = $"{Valor1} * {Valor2 }";
                        Resultado = Valor1 * Valor2;
                        TbDisplay.Text = Resultado.ToString();
                        TbDisplayMini.Text = $"{Valor1} * {Valor2 } ={Resultado}";
                        break;
                    }
                case 4:
                    {
                        Valor2 = Convert.ToDouble(TbDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
                        TbDisplayMini.Text = $"{Valor1} / {Valor2 }";
                        Resultado = Valor1 / Valor2;
                        TbDisplay.Text = Resultado.ToString();
                        TbDisplayMini.Text = $"{Valor1} / {Valor2 } ={Resultado}";
                        break;
                    }
                    
            }

        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            //boton sumar
            Operacion = 1;
            //Valor1 = Convert.ToDouble(TbDisplay.Text);
            Valor1 = Double.Parse(TbDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
            TbDisplayMini.Text = $" { Valor1} +";
            TbDisplay.Text = "";
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            //Boton resta
            Operacion = 2;
            Valor1 = Double.Parse(TbDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
            TbDisplayMini.Text = $" { Valor1} -";
            TbDisplay.Text = "";
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            //boton multiplicacion
            Operacion = 3;
            Valor1 = Double.Parse(TbDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
            TbDisplayMini.Text = $" { Valor1} *";
            TbDisplay.Text = "";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            //boton dividir
            Operacion = 4;
            Valor1 = Double.Parse(TbDisplay.Text, System.Globalization.CultureInfo.InvariantCulture);
            TbDisplayMini.Text = $" { Valor1} /";
            TbDisplay.Text = "";
        }

        
        private void TbDisplayMini_TextChanged(object sender, EventArgs e)
        {
            //string numero = TbDisplay.Text;
            // Concatena el número al texto actual del TextBox
            //TbDisplayMini.Text += numero;
        }

        private void BtnPosandNeg_MouseEnter(object sender, EventArgs e)
        {
            BtnPosandNeg.BackColor = Color.LawnGreen;
        }

        private void BtnPosandNeg_MouseLeave(object sender, EventArgs e)
        {
            BtnPosandNeg.BackColor = SystemColors.Control;
        }

        private void BtnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            BtnLimpiar.BackColor = Color.LawnGreen;
        }

        private void BtnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            BtnLimpiar.BackColor = SystemColors.Control;
        }

        private void BtnSalir_MouseEnter(object sender, EventArgs e)
        {
            BtnSalir.BackColor = Color.LawnGreen;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            BtnSalir.BackColor = SystemColors.Control;
        }
        private void BtnDiv_MouseEnter(object sender, EventArgs e)
        {
            BtnDiv.BackColor = Color.LawnGreen;
        }

        private void BtnDiv_MouseLeave(object sender, EventArgs e)
        {
            BtnDiv.BackColor = SystemColors.Control;
        }
        private void BtnMulti_MouseEnter(object sender, EventArgs e)
        {
            BtnMulti.BackColor = Color.LawnGreen;
        }

        private void BtnMulti_MouseLeave(object sender, EventArgs e)
        {
            BtnMulti.BackColor = SystemColors.Control;
        }
        private void BtnRestar_MouseEnter(object sender, EventArgs e)
        {
            BtnRestar.BackColor = Color.LawnGreen;
        }

        private void BtnRestar_MouseLeave(object sender, EventArgs e)
        {
            BtnRestar.BackColor = SystemColors.Control;
        }
        private void BtnSumar_MouseEnter(object sender, EventArgs e)
        {
            BtnSumar.BackColor = Color.LawnGreen;
        }

        private void BtnRSumar_MouseLeave(object sender, EventArgs e)
        {
            BtnSumar.BackColor = SystemColors.Control;
        }

        private void BtnIgual_MouseEnter(object sender, EventArgs e)
        {
            BtnIgual.BackColor = Color.LawnGreen;
        }

        private void BtnIgual_MouseLeave(object sender, EventArgs e)
        {
            BtnIgual.BackColor = SystemColors.Control;
        }
    }
}
