using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double numero1;
        double numero2;
        String operador;

        public MainWindow()
        {
            InitializeComponent();
        }        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "0";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "1";
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "4";
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + "9";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            operador = "+";
            numero1 = double.Parse(Resultado.Text);
            Resultado.Clear();
            double S = numero1 + numero2;
        }

        private void ButtonResta_Click(object sender, RoutedEventArgs e)
        {
            operador = "-";
            numero1 = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void ButtonMultiplicacio_Click(object sender, RoutedEventArgs e)
        {
            operador = "*";
            numero1 = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void ButtonDivisio_Click(object sender, RoutedEventArgs e)
        {
            operador = "/";
            numero1 = double.Parse(Resultado.Text);
            Resultado.Clear();
        }

        private void ButtonIgual_Click(object sender, RoutedEventArgs e)
        {
            numero2 = double.Parse(Resultado.Text);
            double Suma;
            double Resta;
            double Multi;
            double Div;

            switch (operador) 
            {
                case "+":
                    Suma = numero1 + numero2;
                    Resultado.Text = Suma.ToString();
                    break;
                case "-":
                    Resta = numero1 - numero2;
                    Resultado.Text = Resta.ToString();
                    break;
                case "*":
                    Multi = numero1 * numero2;
                    Resultado.Text = Multi.ToString();
                    break;
                case "/":
                    Div = numero1 / numero2;
                    Resultado.Text = Div.ToString();
                    break;
            }
        }

        private void ButtonBorrarTot_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Clear();
        }

        private void ButtonRetroceder_Click(object sender, RoutedEventArgs e)
        {
            if (Resultado.Text.Length == 1)
                Resultado.Text = "";
            else
                Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1);
        }

        private void ButtonCanviSigne_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = (-1 * int.Parse(Resultado.Text)).ToString();
        }

        private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {
            Resultado.Text = Resultado.Text + ",";
        }
    }
}
