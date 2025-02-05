using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Metodo
{
   public class Calculadora
    {
       
        public static void Adicao(double numero1, double numero2)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
           double valor = numero1 + numero2;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------Resultado Soma-----------------------");
            Console.WriteLine($"O resultado da Soma dos numeros {numero1} + {numero2} é igual a: {valor}");
        }
        public static void Subtracao(double numero1, double numero2)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            double valor = numero1 - numero2;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------Resultado Subtração---------------------");
            Console.WriteLine($"O resultado da Subtração dos numeros {numero1} - {numero2} é igual a: {valor}");
        }
        public static void Multiplicacao(double numero1, double numero2 )
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            double valor = numero1 * numero2;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------Resultado Multiplicação----------------------");
            Console.WriteLine($"O resultado da Multiplicação dos numeros {numero1} * {numero2} é igual a: {valor}");
        }
        public static void Divisao(double numero1, double numero2)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;

            double valor = numero1 / numero2;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------Resultado Divisão------------------------");
            Console.WriteLine($"O resultado da Divisão dos numeros {numero1} / {numero2} é igual a: {valor}");
        }

    }
}
