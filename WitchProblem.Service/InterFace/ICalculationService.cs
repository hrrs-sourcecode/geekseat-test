using System;
using System.Collections.Generic;
using System.Text;
using WitchProblem.DTO;

namespace WitchProblem.Service.InterFace
{
    public interface ICalculationService
    {
        int GetFibonacciByWitchYear(int year);

        decimal GetAveragePeopleKilledByPersonList(IList<Person> personList);
    }
}
