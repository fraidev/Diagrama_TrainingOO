﻿using System;
using System.Collections.Generic;

namespace Diagrama.Domain
{
    public class Automoveis
    {
        public int MaxAutomoveis { get; set; }
        public int NumAutomoveis { get; set; }
        public Automovel[] ListaDeAutomoveis { get; set; }
    }
}