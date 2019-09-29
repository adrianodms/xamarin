using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrive.Models;
using TestDrive.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {

        public AgendamentoViewModel ViewModel { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.ViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.ViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert(
                "Agendamento",
                string.Format(
                    @"Nome: {0}, Fone:{1}, E-mail:{2}, Data Agendamento: {3:dd/MM/yyyy}, Hora Agendamento: {4}",
                   this.ViewModel.Nome, this.ViewModel.Fone, this.ViewModel.Email, this.ViewModel.DataAgendamento, this.ViewModel.HoraAgendamento),
                "OK"
                );
        }
    }
}