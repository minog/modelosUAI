using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private decimal primerNumero;
        private string nombreOperador;
        private bool isOperadorClicked;

        private void BtnCommon_Clicked(object sender, EventArgs e)
        {
           var button = sender as Button;
            if (lblResultado.Text=="0" || isOperadorClicked)
            {
                isOperadorClicked = false;
                lblResultado.Text = button.Text;
            }
            else
            {
                lblResultado.Text += button.Text;
            }
        }

        private void BtnClear_Clicked(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            isOperadorClicked=false;
            primerNumero = 0;

        }

        private void BtnX_Clicked(object sender, EventArgs e)
        {
            string number = lblResultado.Text;
            if (number != "0")
            {
                number = number.Remove(number.Length -1, 1);
                if (string.IsNullOrEmpty(number))
                {
                    lblResultado.Text = "0";
                }
                else
                {
                    lblResultado.Text = number;
                }
            }
            
        }

        public void BtnCommonOperation_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            isOperadorClicked = true;
            nombreOperador = button.Text;
            primerNumero = Convert.ToDecimal(lblResultado.Text);

        }

        private async void BtnPorcentaje_Clicked(object sender, EventArgs e)
        {
            try
            {
                string number = lblResultado.Text;
                if (number != "0")
                {
                    decimal porcentajeValue = Convert.ToDecimal(number);
                    string result = (porcentajeValue / 100).ToString("0.##");
                    lblResultado.Text = result;
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error ",ex.Message,"OK");
            }
        }

        private void BtnEqual_Clicked(object sender, EventArgs e)
        {
            try
            {
                decimal segundoNumero = Convert.ToDecimal(lblResultado.Text);
                string resultadoFinal = Calcular(primerNumero,segundoNumero,nombreOperador).ToString("0.##");
                lblResultado.Text = resultadoFinal;
            }
            catch (Exception ex)
            {

                DisplayAlert("Error",ex.Message,"OK");
            }
        }

        public decimal Calcular(decimal primerNumero,decimal segundoNumero,string nombreOperador)
        {
            decimal resultado = 0;
            if (nombreOperador == "+")
            {
                resultado = primerNumero + segundoNumero;
            }
            else if (nombreOperador == "-")
            {
                resultado = primerNumero - segundoNumero;
            }
            else if(nombreOperador == "*")
            {
                resultado = primerNumero * segundoNumero;
            }
            else if (nombreOperador == "/")
            {
                resultado = primerNumero / segundoNumero;
            }

            return resultado;

        }
    }
}
