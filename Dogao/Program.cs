using System;
using System.Globalization;

namespace Dogao
{
    class Program
    {
        /// <summary>
        /// O programa "Dogao" foi criado baseado na seguinte tabela
        /// 
        /// codigo  especifiação        preço
        /// 1       Cachorro Quente     R$4.00
        /// 2       X=Salada            R$4.50
        /// 3       X=Bacon             R$5.00
        /// 4       Torrada simples     R$2.00
        /// 5       Refrigerante        R$1.50
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o código do item e sua quantidade separados por espaços:");
                string[] entrada = Console.ReadLine().Split(' ');

                int cod = int.Parse(entrada[0]);
                int qtde = int.Parse(entrada[1]);
                double total;

                switch (cod)
                {
                    case 1:
                        total = qtde * 4.00;
                        break;
                    case 2:
                        total = qtde * 4.50;
                        break;
                    case 3:
                        total = qtde * 5.00;
                        break;
                    case 4:
                        total = qtde * 2.00;
                        break;
                    case 5:
                        total = qtde * 1.50;
                        break;
                    default:
                        total = 0;
                        break;
                }

                Console.WriteLine($"Total a pagar: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
