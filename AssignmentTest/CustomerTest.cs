using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment;
using NUnit.Framework;

namespace AssignmentTest
{
    [TestFixture]
    public class CustomerTest
    {
        Customer c1;

        [SetUp]
        public void Init ()
        {
            c1 = new Customer();
        }

        [TestCase(36, "female",ExpectedResult = 3.5)]
        [TestCase(15, "female",ExpectedResult = 0)]
        [TestCase(25, "female",ExpectedResult = 5)]
        [TestCase(37, "male",ExpectedResult = 5)]
        [TestCase(17, "male", ExpectedResult = 0)]
        [TestCase(30, "male", ExpectedResult = 6)]
        [TestCase(60, "", ExpectedResult = 0)]
        [TestCase(25, "", ExpectedResult = 0)]
        public double TestCalcPremium (int age, string gender)
        {
            return c1.CalcPremium(age, gender);
        }
    }
}
