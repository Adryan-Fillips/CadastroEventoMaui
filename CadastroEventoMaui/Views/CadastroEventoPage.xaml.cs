using CadastroEventoMaui.Models;
using CadastroEventoMaui.Views;
using Microsoft.Maui.Controls;

namespace CadastroEventoMaui.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public Evento Evento { get; set; }
        public Command NavegarParaResumoCommand { get; set; }

        public CadastroEventoPage()
        {
            InitializeComponent();
            Evento = new Evento();
            NavegarParaResumoCommand = new Command(NavegarParaResumo);
            BindingContext = this;
        }

        private async void NavegarParaResumo()
        {
            // Navegar para a página de resumo
            await Navigation.PushAsync(new ResumoEventoPage(Evento));
        }
    }
}