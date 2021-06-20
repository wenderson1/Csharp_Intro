using System;

namespace Estrutura_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma sequência de números separados por espaço");

            var numerosTexto = Console.ReadLine();

            var numeros = numerosTexto.Split(' ');
            Console.WriteLine("Numeros: ");

            #region Laço de repetição - For
            Console.WriteLine("Usando For");
            for (int i=0;i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            #endregion

            #region Laço de repetição - While
            var contador = 0;
            Console.WriteLine("Numeros: ");
            Console.WriteLine("Usando Foreach");
            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);
                contador++;
            }
            #endregion

            #region Laço de repetição - foreach
           
            Console.WriteLine("Numeros: ");
            Console.WriteLine("Usando Foreach");
            foreach(var x in numeros)
            {
                Console.WriteLine(x);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
