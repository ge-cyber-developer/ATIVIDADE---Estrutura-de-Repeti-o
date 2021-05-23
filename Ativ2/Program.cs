using System;

namespace Ativ2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite um nome de usuário:");
                string NomeUsuario = Console.ReadLine();

                Console.WriteLine("Digite uma senha:");
                string Senha = Console.ReadLine();

                if (Senha == NomeUsuario )
                {
                    Console.WriteLine("Por favor, digite uma senha que não cotenha seu nome de usuário.");
                }
                else
                {
                    Console.WriteLine("Perfil criado com sucesso!");
                    break;
                }

            }

        }
    }
}
