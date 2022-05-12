using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using cadernoVirtual.Materias3;

namespace cadernoVirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Terceiro : ContentPage
    {
        public Terceiro()
        {
            InitializeComponent();
        }

 private void Button_Clicked(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Biologia());
    }
 private void Button_Clicked1(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.EdFisica());
    }
  private void Button_Clicked2(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Filosofia());
    }
 private void Button_Clicked3(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Fisica());
    }  
 private void Button_Clicked4(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Geografia());
    }
 private void Button_Clicked5(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Historia());
    }
 private void Button_Clicked6(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Ingles());
    }
 private void Button_Clicked7(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Internet());
    }
     private void Button_Clicked8(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Matematica());
    }
     private void Button_Clicked9(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Portugues());
    }
     private void Button_Clicked10(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.ProgMobile2());
    }
     private void Button_Clicked11(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.ProgWeb3());
    }
     private void Button_Clicked12(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Quimica());
    }
      private void Button_Clicked13(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.QualidadeSoftware());
    }
     private void Button_Clicked14(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Sociologia());
    }
     private void Button_Clicked15(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.TCC());
    }


    }
}        