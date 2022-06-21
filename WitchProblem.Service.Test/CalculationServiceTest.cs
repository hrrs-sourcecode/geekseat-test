using System;
using System.Collections.Generic;
using WitchProblem.DTO;
using WitchProblem.Service.InterFace;
using Xunit;

namespace WitchProblem.Service.Test
{
    public class CalculationServiceTest
    {
        private ICalculationService _calculationService;
        private IList<Person> _dummyPerson;

        public CalculationServiceTest()
        {
            _calculationService = new CalculationService();
            _dummyPerson = new List<Person>
            {
                new Person { YearOfDeath = 12, AgeOfDeath = 10 },
                new Person { YearOfDeath = 17, AgeOfDeath = 13 }
            };
        }

        [Fact]
        public void TestGetAveragePeopleKilledByPersonList_ReturnSuccess()
        {
            decimal expectedResult = 4.5m;
            decimal actualResult = 0;

            actualResult = _calculationService.GetAveragePeopleKilledByPersonList(_dummyPerson);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetAveragePeopleKilledByPersonList_ReturnError()
        {
            decimal expectedResult = -1;
            decimal actualResult = 0;

            _dummyPerson.Add(new Person { YearOfDeath = 10, AgeOfDeath = 12 });

            actualResult = _calculationService.GetAveragePeopleKilledByPersonList(_dummyPerson);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetFibonacciByWitchYear_ReturnSuccess()
        {
            int expectedResult = 7;
            int actualResult = -1;

            actualResult = _calculationService.GetFibonacciByWitchYear(4);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestGetFibonacciByWitchYear_ReturnError()
        {
            string expectedResult = "An exception has been thrown";

            Action act = () => _calculationService.GetFibonacciByWitchYear(-10);

            Exception exception = Assert.Throws<Exception>(act);

            Assert.Equal(expectedResult, exception.Message);
        }
    }
}
