﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class CalculaDesconto
    {
        public static double Calcular(double valor, double desconto)
        {
            return valor - (valor * desconto / 1000);
        }
    }
}
