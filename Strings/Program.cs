using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string frase = "    C# é uma linguagem de programação versátil. "
                + "Com  ele consigo desenvolver para Web, Desktop e Jogos"
                + "Mobile entre outros";

            
            //Length
            var tamanho = frase.Length;

            //Empty
            var vazio = string.Empty;

            //ToLower, ToUpper
            var paragrafoMaiusulo = frase.ToUpper();
            var paragrafoMinusculo = frase.ToLower();

            //Split
            var frases = frase.Split(".");

            //Trim, TrimEnd, TrimStart
            Console.WriteLine(frase.Trim());
            Console.WriteLine(frase.TrimEnd());
            Console.WriteLine(frase.TrimStart());

            //IsNullOrWhitespace
            var isNullOrWhitespace = string.IsNullOrWhiteSpace(frase);

            //Replace
            var paragrafoCSharp = frase.Replace("C#", "CSharp");
            Console.WriteLine(paragrafoCSharp);
           

            //IndexOf
            var indexOf = frase.IndexOf("C#");

            //LastIndexOF
            var lastIndexOf = frase.LastIndexOf("C#");

            //StartsWith
            var startsWith = frase.StartsWith("C#");

            //Substring
            var indexOfMobile = frase.IndexOf("Mobile");
            var substring = frase.Substring(indexOfMobile, 20);

            //Contains
            
            var contains = frase.Contains("mobile");

            Console.ReadKey();

        }
    }
}
