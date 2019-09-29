using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TestDrive.Models;

namespace TestDrive.ViewModels
{
    public class DetalheViewModel : INotifyPropertyChanged
    {
        public Veiculo Veiculo { get; set; }

        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio Abs - {0:c}", Veiculo.FREIO_ABS);
            }
        }
        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar condicionado - {0:c}", Veiculo.AR_CONDICIONADO);
            }
        }
        public string TextoMP3Player
        {
            get
            {
                return string.Format("MP3 Player - {0:c}", Veiculo.MP3_PLAYER);
            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.PrecoTotalFormatado;
            }
        }

        public bool TemFreioABS
        {
            get { return Veiculo.TemFreioABS; }
            set
            {
                Veiculo.TemFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemArCondicionado
        {
            get { return Veiculo.TemArCondicionado; }
            set
            {
                Veiculo.TemArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }


        public bool TemMP3Player
        {
            get { return Veiculo.TemMP3Player; }
            set
            {
                Veiculo.TemMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public DetalheViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
        }
    }
}
