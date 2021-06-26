using System;

namespace DebugandoAplicacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //f10 para ir passando para a frente
            var numerosString = Console.ReadLine();
            var numeros = numerosString.Split(' '); //se estiver errado, posso testar mudando o valor da váriavel e avançar com o código

            foreach(var numero in numeros)
            {
                var numeroInt = int.Parse(numero);

                var aoQuadrado = Math.Pow(numeroInt, 2);

                Console.WriteLine($"{numeroInt}2 = {aoQuadrado}");

            }
        }
    }
}
