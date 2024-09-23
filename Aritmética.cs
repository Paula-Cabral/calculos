using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    //Implementa operações aritméticas
    class Aritmética
    {
        /// <summary>
        /// Operação soma
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna a soma de dois números</returns>
        public int Somar(int x, int y)
        {

            return x + y;
        }
        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna o resultado da subtração de dois numeros</returns>
        public int Subtrair(int x, int y)
        {

            return x - y;
        }
    }
}
