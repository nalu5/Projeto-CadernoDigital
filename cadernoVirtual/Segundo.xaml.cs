using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using cadernoVirtual.Materias2;

namespace cadernoVirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Segundo : ContentPage
    {
        public Segundo()
        {
            InitializeComponent();
        }

 private void Button_Clicked(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.BancoDados2());
    }
 private void Button_Clicked1(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Biologia());
    }
  private void Button_Clicked2(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.DS());
    }
 private void Button_Clicked3(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.EdFisica());
    }  
 private void Button_Clicked4(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Etica());
    }
 private void Button_Clicked5(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Filosofia());
    }
 private void Button_Clicked6(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Fisica());
    }
 private void Button_Clicked7(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Geografia());
    }
     private void Button_Clicked8(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Historia());
    }
     private void Button_Clicked9(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Ingles());
    }
     private void Button_Clicked10(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Matematica());
    }
     private void Button_Clicked11(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Matematica());
    }
     private void Button_Clicked12(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.ProgMobile());
    }
      private void Button_Clicked13(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.ProgWeb2());
    }
     private void Button_Clicked14(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Quimica());
    }
     private void Button_Clicked15(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.SistemasEmbarcados());
    }
     private void Button_Clicked16(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias2.Sociologia());
    }

    }
}        