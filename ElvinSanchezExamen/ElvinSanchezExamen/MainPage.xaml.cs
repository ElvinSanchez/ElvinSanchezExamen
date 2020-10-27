using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElvinSanchezExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            //para el texto de login
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user != "estudiante2020" || pass != "uisrael2020")
            {
                await DisplayAlert("Alerta", "Usuario Invalido", "Reintentar");
                return;
            }
            else
            {
                await Navigation.PushAsync(new Registro(user, pass));
                await DisplayAlert("Felicidades", "Bienvenido al Curso Online", "Aceptar");
            }
        }
    }
}
