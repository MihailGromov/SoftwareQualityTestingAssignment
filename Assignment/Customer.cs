﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Customer
    {
        public float CalcPremium(int age, string gender)
        {
            float premium;
            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                    premium = 5.0f;
                else if (age >= 31)
                    premium = 3.50f;
                else
                    premium = 0.0f;
            }
            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                    premium = 6.0f;
                else if (age >= 36)
                    premium = 5.0f;
                else
                    premium = 0.0f;
            }
            else
                premium = 0;

            if (age >= 50)
                premium = premium * .5f;
            return premium;
        }
    }
}
