using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DateTime Principais Métodos
            var now = DateTime.Now;
            //Console.WriteLine(now.ToString());

            var today = DateTime.Today;
            //Console.WriteLine(today.ToString());

            var threeDaysAgo = today.AddDays(-3);
            //Console.WriteLine(threeDaysAgo);

            var sixmonths = today.AddMonths(6);
            //Console.WriteLine(sixmonths);

            var twoYearsLater = today.AddYears(2);
            //Console.WriteLine(twoYearsLater);

            var shortDate = now.ToShortDateString();
            //Console.WriteLine(shortDate);
            var longDate = now.ToLongDateString();
            //Console.WriteLine(longDate);

            var shortTime = now.ToShortTimeString();
            //Console.WriteLine(shortTime);
            var longTime = now.ToLongTimeString();
            //Console.WriteLine(longTime);

            var date = now.Date;
            var day = now.Day;
            var month = now.Month;
            var year = now.Year;
            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;

            var dayOffYear = now.DayOfWeek;

            if(dayOffYear == DayOfWeek.Saturday || dayOffYear == DayOfWeek.Sunday)
            {
                Console.WriteLine("Oba fim de semana :D");
            }
            else
            {
                Console.WriteLine("Semana :(");
            }
            #endregion

            #region DateTime Formatação
            var formats = new string[] { 
                "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "T", "u", "U", "Y"
            };

            foreach(var format in formats)
            {
                Console.WriteLine("Data no formato {0}: {1}", format, now.ToString(format));                
                //Console.WriteLine($"Data no formato {format}: {now.ToString(format)}");                
            }

            Console.WriteLine("Diferentes maneiras de formatar manualmente");
            Console.WriteLine($"Data no formato d: {now:d}");
            Console.WriteLine($"Data no formado MM-dd-yyyy:{now:MM-dd-yyyy}");
            var dateFormat = now.ToString("MM-dd-yyyy");
            var dateFormatBr = now.ToString("dd/MM/yyyy HH:mm:ss");
            #endregion

        }
    }
}
