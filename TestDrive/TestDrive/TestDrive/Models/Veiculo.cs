﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrive.Models
{
    public class Veiculo
    {
        public const decimal FREIO_ABS = 800;
        public const decimal AR_CONDICIONADO = 1000;
        public const decimal MP3_PLAYER = 500;

        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("{0:c}", this.Preco);
            }
        }

        public bool TemFreioABS { get; set; }
        public bool TemArCondicionado { get; set; }
        public bool TemMP3Player { get; set; }

        public string PrecoTotalFormatado
        {
            get
            {
                decimal valorTotal = Preco
                    + (TemFreioABS ? FREIO_ABS : 0)
                    + (TemArCondicionado ? AR_CONDICIONADO : 0)
                    + (TemMP3Player ? MP3_PLAYER : 0);
                return string.Format("Valor Total: {0:c}", valorTotal);
            }
        }
    }
}
