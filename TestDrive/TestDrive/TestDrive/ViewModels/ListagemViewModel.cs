﻿using System;
using System.Collections.Generic;
using System.Text;
using TestDrive.Models;

namespace TestDrive.ViewModels
{
    class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemViewModel()
        {
            this.Veiculos = new ListagemVeiculos().Veiculos;
        }
    }
}
