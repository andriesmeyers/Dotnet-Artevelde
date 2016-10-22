using System;
using Xunit;
using Models;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void EmployeeStringTest() 
        {
            string firstName = "Philippe";
            string surName = "De Pauw - Waterschoot";
            string number = "666-66666-666";

            string expected = String.Format("Employee: {0} {1}", firstName, surName);;
            string actual = new Employee(firstName, surName, number).ToString();

            Assert.Equal(expected, actual);
        }
    }
}
