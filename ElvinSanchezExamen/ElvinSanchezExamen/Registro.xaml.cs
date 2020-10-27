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
    }
}