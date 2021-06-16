using System;

namespace CsharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de Dados
            int numeroInt = 10;
            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = long.MaxValue;
            Console.WriteLine(numeroLong);

            decimal numeroDecimal = 10.523123213123132m;

            double numeroDouble = 12.9923;
            double menorNumeroDouble = double.MinValue;

            bool verdadeiro = true;
            bool falso = false;

            string nome = "Wenderson Farias";
            char letra = 'W';

            DateTime entradaEmpresa = new DateTime(2021, 1, 1);
            //representa um intervalo de tempo
            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;
            #endregion

            #region Conversões

            int notaAluno = 10;
            //conversão implicita
            double notaAlunoDouble = notaAluno;

            //Conversão explicita
            int notaAluno1 = (int)notaAlunoDouble;

            //Conversão utilizando Convert
            string notaString = "10";

            int notaConvert = Convert.ToInt32(notaString);

            //Coversão utilizando Parse
            int notaParse = int.Parse(notaString);

            if (int.TryParse(notaString, out int notaTryParse))
            {

            }
            else
            {
                Console.WriteLine("Numero em formato Invalido");
            }
            #endregion

            #region Operadores Aritmeticos
            //Unários ++, --. + e -
            int numeroOperador = 4;
            Console.WriteLine(numeroOperador++);//4
            Console.WriteLine(numeroOperador--);//5

            Console.WriteLine(--numeroOperador);//5
            Console.WriteLine(++numeroOperador);//4

            Console.WriteLine(numeroOperador);
            Console.WriteLine(-numeroOperador);
            Console.WriteLine(-(-numeroOperador));

            //Binários * / + - 
            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var multiplicacao = 4 * 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 3;
            var multiplos = (4 * 5) + 10;

            #endregion

            #region Operadores de Comparação > >= < <=
            Console.WriteLine(4 > 5);
            Console.WriteLine(5 >= 5);
            Console.WriteLine(5 >= 5);
            Console.WriteLine(5 < 4);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 < 6);
            #endregion

            #region Operadores de Igualdade
            Console.WriteLine(5 == 5);
            Console.WriteLine(5 != 6);
            #endregion

            #region Operadores Logicos AND(&&) e OR(||) 
            Console.WriteLine(true ||false);
            Console.WriteLine(false||true);
            Console.WriteLine(true||true);
            Console.WriteLine(false||false);

            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            #endregion
            Console.Read();
        }
    }
}
