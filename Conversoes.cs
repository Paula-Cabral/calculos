using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// implementa operações de conversões
    /// </summary>
    static class  Conversoes
    {
        /// <summary>
        /// Tipo de conversão
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0;
            CelsiusFahrenheit, FahrenheitCelsius

        }
        /// <summary>
        /// Conversão de Temperaturas
        /// </summary>
        /// <param name="conversao">Conversão a efetuara</param>
        /// <param name="temperatura">Temperatura a converter</param>
        /// <returns>O resultado da conversão</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {

                return ((temperatura - 32) / 1.8000);
            }
            return -1;

        }
    }
}
