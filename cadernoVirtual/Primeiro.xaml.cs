using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using cadernoVirtual.Materias1;

namespace cadernoVirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Primeiro : ContentPage
    {
        public Primeiro()
        {
            InitializeComponent();
        }

 private void Button_Clicked(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Algoritimo());
    }
 private void Button_Clicked1(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Analise());
    }
  private void Button_Clicked2(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Artes());
    }
 private void Button_Clicked3(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.BancoDados());
    }  
 private void Button_Clicked4(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Biologia());
    }
 private void Button_Clicked5(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Design());
    }
 private void Button_Clicked6(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.EdFisica());
    }
 private void Button_Clicked7(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Filosofia());
    }
     private void Button_Clicked8(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Fisica());
    }
     private void Button_Clicked9(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.FundamentosTI());
    }
     private void Button_Clicked10(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Geografia());
    }
     private void Button_Clicked11(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Historia());
    }
     private void Button_Clicked12(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Ingles());
    }
      private void Button_Clicked13(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Matematica());
    }
     private void Button_Clicked14(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Portugues());
    }
     private void Button_Clicked15(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Progweb());
    }
     private void Button_Clicked16(object sender, EventArgs e)
    {
        Navegation.PushAsync (new Materias1.Quimica());
    }

    }
}        