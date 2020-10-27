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
    public partial class Registro : ContentPage
    {
        public Registro(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                if (dato1 < 1800)
                {
                    double saldo = 1800 - dato1;
                    double cuota = saldo / 3;
                    double parte = cuota + (cuota * 0.05);
                    txtDato2.Text = parte.ToString();
                    txtDato3.Text = parte.ToString();
                    txtDato4.Text = parte.ToString();                
                }
                else
                {
                    if (dato1 == 1800)
                    {
                        double parte = 0;
                        txtDato2.Text = parte.ToString();
                        txtDato3.Text = parte.ToString();
                        txtDato4.Text = parte.ToString();
                        DisplayAlert("Notificación", "Curso Cancelado en su Totalidad", "Ok");
                    }
                    else
                    {
                        if (dato1 > 1800)
                        {
                            txtDato2.Text = "";
                            txtDato3.Text = "";
                            txtDato4.Text = "";
                            DisplayAlert("Alerta", "Revise sus Valores Ingresados", "Reintentar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", "ERROR" + ex.Message, "Ok.");
            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text == null)
            {
                DisplayAlert("Error", "Ingrese Datos", "Reintentar");
            }
            else
            {
                if (txtDato1.Text == null)
                {
                    DisplayAlert("Error", "Ingrese Datos", "Reintentar");
                }
                else
                {
                    DisplayAlert("Confirmación", "Elemento guardado con Exito", "Ok");
                }
            }
        }

        private async void btnResumen_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            await Navigation.PushAsync(new Resumen(nombre, apellido));
        }
    }
}