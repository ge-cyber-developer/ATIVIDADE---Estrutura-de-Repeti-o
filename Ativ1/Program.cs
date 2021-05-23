using System;

namespace Ativ1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
               Console.WriteLine("Digite uma nota de 1 a 10: ");
               int nota = int.Parse(Console.ReadLine());

               
               if (nota <= 10 && nota >= 1)
               {
                  Console.WriteLine("Obrigada pela nota!");
                  break;
               }
               else
               {
                   Console.WriteLine("Rsposta Inválida! Por favor tente novamente.");
               }


            }
        }
    }
}
