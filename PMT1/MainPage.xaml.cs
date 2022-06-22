using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PMT1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void sumar_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            int resultado1 = 0;

            resultado1 = num1 + num2;

            

            var ope = new NewFolder1.operacion
            {

                resultado = Convert.ToString(resultado1)
            };

           
            var segpage = new Page2();
            segpage.BindingContext = ope;
            Navigation.PushAsync(segpage);
        }

        private void Restar_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            int resultado1 = 0;

            resultado1 = num1 - num2;



            var ope = new NewFolder1.operacion
            {

                resultado = Convert.ToString(resultado1)
            };


            var segpage = new Page2();
            segpage.BindingContext = ope;
            Navigation.PushAsync(segpage);
        }

        private void Dividir_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            int resultado1 = 0;

            resultado1 = num1 / num2;



            var ope = new NewFolder1.operacion
            {

                resultado = Convert.ToString(resultado1)
            };


            var segpage = new Page2();
            segpage.BindingContext = ope;
            Navigation.PushAsync(segpage);
        }

        private void Multiplicar_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtnum1.Text);
            int num2 = Convert.ToInt32(txtnum2.Text);
            int resultado1 = 0;

            resultado1 = num1 * num2;



            var ope = new NewFolder1.operacion
            {

                resultado = Convert.ToString(resultado1)
            };


            var segpage = new Page2();
            segpage.BindingContext = ope;
            Navigation.PushAsync(segpage);
        }
    }
}
