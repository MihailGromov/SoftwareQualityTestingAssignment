using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixture
{
    public class FixtureTest : fit.ColumnFixture
    {
        public Customer c = new Customer();
        public string gender;
        public int age;

        public float CalcPremium()
        {
            return c.CalcPremium(age, gender);
        }
    }
}
