using System;

namespace Ativ3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("Nome inválido. Por favor digite novamente.");
                }
                else
                {
                    Console.WriteLine("Nome validado com sucesso!");
                    break;
                }

            }

            while (true)
            {
            
                Console.WriteLine("Digite seu idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade > 0  && idade <= 150)
                {
                    Console.WriteLine("Idade validada com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Idade inválida. Por favor digite novamente.");
                }

            }

            while (true)
            {

                Console.WriteLine("Digite seu salário: ");
                int salario = int.Parse(Console.ReadLine());

                if (salario > 0)
                {
                    Console.WriteLine("Salário validada com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Salário inválido. Por favor digite novamente.");
                }

            }

            while (true)
            {

                Console.WriteLine("Digite seu estado civil ( S = solteiro | C = casado | V = viúvo | D = divorciado): ");
                string estadocivil = Console.ReadLine();

                if (estadocivil == "S" || estadocivil == "C" || estadocivil == "V" || estadocivil == "D"  )
                {
                    Console.WriteLine("Estado Civil validada com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Estado Civil inválido. Por favor digite novamente.");
                }

            }

            
        }
    }
}
