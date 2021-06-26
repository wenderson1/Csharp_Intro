using System;

namespace Tratamento_Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var seteString = "sete";
            string valorNull = null;
            var longValue = long.MaxValue.ToString();

            try
            {
               // var formatException = int.Parse(seteString);
                //var argumentNullException = int.Parse(valorNull);
                var overflowException = int.Parse(longValue);
            }
            catch(FormatException exception)
            {
                Console.WriteLine("Format Exception:");
                Console.WriteLine(exception);
                Console.WriteLine(exception.Message);
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine("Argument Null Exception");
                Console.WriteLine(exception.Message);
            }
            catch(OverflowException exception)
            {
                Console.WriteLine("Overflow Exception");
                Console.WriteLine(exception);
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Este código sempre é executado");
            }
        }
    }
}
