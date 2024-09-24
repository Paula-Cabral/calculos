using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    //Implementa operações aritméticas
    static class  Aritmética
    {
        

        /// <summary>
        /// Operação soma
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna a soma de dois números</returns>
        public  static int Somar(int x, int y)
        {

            return x + y;
        }
        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna o resultado da subtração de dois numeros</returns>
        public static int Subtrair(int x, int y)
        {

            return x - y;
        }

        public static int Multiplicar(int x, int y)
        {

            return x * y;
        }

    }


}
