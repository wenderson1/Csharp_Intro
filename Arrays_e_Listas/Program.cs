using System;
using System.Collections.Generic;

namespace Arrays_e_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            int[] matriz = { 1, 2, 3 };
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbersCopy = new int[10];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }

            var numbersString = "0 1 2 3 4 5 6 7 8 9";
            var numbersArray = numbersString.Split(' ');
            var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);
            #endregion

            #region Listas
            var list = new List<int> { 0,1,2,3,4};
            var listFromArray = new List<int>(numbers);

            list.Add(5);
            list.AddRange(new List<int> { 6, 7 });
            list.AddRange(numbers);

            var count = list.Count;
            var contains14 = list.Contains(14);
            var contains2 = list.Contains(2);

            Console.WriteLine("Lista Reversa");
            list.Reverse();
            list.ForEach(l => Console.WriteLine(l));

            Console.WriteLine("Lista Ordenada");
            list.Sort();
            list.ForEach(l => Console.WriteLine(l));

            list.Remove(4);
            list.RemoveAll(x => x > 5);

            list.Clear();

            #endregion 

        }
    }
}
