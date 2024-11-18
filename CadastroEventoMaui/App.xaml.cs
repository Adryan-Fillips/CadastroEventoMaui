using CadastroEventoMaui.Views;
using Microsoft.Maui.Controls;

namespace CadastroEventoMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CadastroEventoPage());
        }
    }
}