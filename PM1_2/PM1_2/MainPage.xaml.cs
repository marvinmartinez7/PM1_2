using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtedad.Text);
            var emple = new Models.Personas
            {
               
                name = txtnombre.Text,
                apellidos = txtapellido.Text,
                edad=n1,
                correo = txtcorreo.Text,

            };
            var pagetwo = new Views.PageLista();
            pagetwo.BindingContext = emple;
            await Navigation.PushAsync(pagetwo);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
