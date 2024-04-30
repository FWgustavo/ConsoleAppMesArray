using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            Console.WriteLine("Digite o número de um mês: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês escolhido foi: " + mes[i-1]);
            Console.ReadKey();
        }
    }
}
