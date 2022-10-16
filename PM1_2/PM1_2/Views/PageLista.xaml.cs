using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM1_2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLista : ContentPage
    {
        public PageLista()
        {
            InitializeComponent();
        }

        public PageLista(String nombre,String apellido,String edad,String correo)
        {
            InitializeComponent();
            lbresultado1.Text = nombre + " " + apellido+" "+edad+" "+correo;

        }
    }
}