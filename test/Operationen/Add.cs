﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalc
{
    public class Add : Results
    {
        void Plus(int z1, int z2)
        {
            result = z1 + z2;

        }

        void Plus(double z1, double z2)
        {

            result = z1 + z2;

        }

        void Plus(float z1, float z2)
        {
            result = z1 + z2;

        }
    }
}
