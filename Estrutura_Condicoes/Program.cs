using System;

namespace Estrutura_Condicoes
{
    class Program
    {
        static void Main(string[] args)
        {
           #region Estrutura de Condicao IF
            var notaDigitada = Console.ReadLine();
            var nota = int.Parse(notaDigitada);

            if (nota >= 70)
            {
                Console.WriteLine("Aprovado");
            }
            else if(nota >= 40)
            {
                Console.WriteLine("Em Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
            #endregion

           #region Estrutura de Condicao Switch-Case
            Console.WriteLine("Seja bem-vindo a empresa Xcom");
            Console.WriteLine("Digite 1 - Contratação de um plano");
            Console.WriteLine("Digite 2 - Reclamação de serviço prestado");
            Console.WriteLine("Digite 3 - Segunda Via de Boleto");
            Console.WriteLine("Digite 4 - Sair");

            var opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Console.WriteLine("Informações do Plano Novo");
                    break;

                case "2":
                    Console.WriteLine("Fale sobre sua reclamação");
                    break;

                case "3":
                    Console.WriteLine("Segunda via de boleto enviada por e-mail");
                    break;

                case "4":
                    Console.WriteLine("Tenha um bom dia");
                    break;

                default:
                    Console.WriteLine("Opcao Invalida");
                    break;
            }
            #endregion
        }
    }
}
