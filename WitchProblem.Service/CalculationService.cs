using System;
using System.Collections.Generic;
using WitchProblem.DTO;
using WitchProblem.Service.InterFace;

namespace WitchProblem.Service
{
    public class CalculationService : ICalculationService
    {
        public CalculationService()
        {

        }

        public int GetFibonacciByWitchYear(int year)
        {
            if (year < 0) throw new Exception("An exception has been thrown");

            int result = 0;
            int previousNum = 0;
            int beforePreviousNum = 0;

            

            for (int i = 0, num = 0; i < year; i++)
            {
                beforePreviousNum = previousNum;
                previousNum = num;
                if (i > 0)
                {
                    num = previousNum + beforePreviousNum;
                }
                else
                {
                    num = 1;
                }
                result += num;
            }

            return result;
        }

        public decimal GetAveragePeopleKilledByPersonList(IList<Person> personList)
        {
            decimal result = 0;

            try
            {
                foreach(Person person in personList)
                {
                    result += GetFibonacciByWitchYear(person.YearOfDeath - person.AgeOfDeath);
                }
            }
            catch (Exception ex)
            {
                return - 1;
            }

            return result/personList.Count;
        }
    }
}
