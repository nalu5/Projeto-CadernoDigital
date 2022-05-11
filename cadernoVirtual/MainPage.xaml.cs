using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using cadernoVirtual.Primeiro;
using cadernoVirtual.Segundo;
using cadernoVirtual.Terceiro;

namespace cadernoVirtual
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    
    private void Button_Clicked1(object sender, EventArgs e)
    {
        Navegation.PushAsync (new cadernoVirtual.Primeiro());
    }

    private void Button_Clicked2(object sender, EventArgs e)
    {
        Navegation.PushAsync (new cadernoVirtual.Segundo());
    }

    private void Button_Clicked3(object sender, EventArgs e)
    {
        Navegation.PushAsync (new cadernoVirtual.Terceiro());
    }

    }
}
