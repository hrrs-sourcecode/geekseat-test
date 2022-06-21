using System;
using System.Collections.Generic;
using WitchProblem.DTO;
using WitchProblem.Service;
using WitchProblem.Service.InterFace;

namespace WitchProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICalculationService calc = new CalculationService();

            decimal average = 0;

            //Console.WriteLine(calc.GetFibonacciByWitchYear(10));

            average = calc.GetAveragePeopleKilledByPersonList(new List<Person>
            {
                new Person { YearOfDeath = 12, AgeOfDeath = 10 },
                new Person { YearOfDeath = 17, AgeOfDeath = 13 }
            });

            Console.WriteLine(average);


            Console.ReadLine();
        }
    }
}
