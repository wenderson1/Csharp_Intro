using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student(1,"Luis","1234443243243",100),
                new Student(2,"Wenderson","1234443243243",35),
                new Student(3,"Bianca","1234443243243",85),
                new Student(4,"Helena","1234443243243",70),
                new Student(5,"Roberto","1234443243243",55),
                new Student(6,"Pedro","1234443243243",87),
            };

            var any = students.Any();
            var any100 = students.Any(s => s.Grade == 100);

            var single = students.Single(s => s.Id == 1);
            var singleDefault = students.SingleOrDefault(s => s.Grade == 0);



            Console.ReadKey();
        }
    }
}
