using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElvinSanchezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string apellido)
        {
            InitializeComponent();
            string name = lblNombre.Text;
            lblNombre.Text = name + nombre;

            
        }
    }
}