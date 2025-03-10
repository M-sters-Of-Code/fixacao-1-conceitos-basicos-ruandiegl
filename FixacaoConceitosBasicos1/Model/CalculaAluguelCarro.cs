using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int kmInicial, int kmFinal)
        {
            double precoDia = 90.0;
            double precoKm = 0.20;
            int kmRodados = kmFinal - kmInicial;

            return (dias * precoDia) + (kmRodados * precoKm);
        }
    }
}
