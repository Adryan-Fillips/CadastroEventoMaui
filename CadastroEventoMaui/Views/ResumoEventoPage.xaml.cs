using CadastroEventoMaui.Models;
using Microsoft.Maui.Controls;

namespace CadastroEventoMaui.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public Evento Evento { get; set; }

        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            Evento = evento;
            BindingContext = this;
        }
    }
}