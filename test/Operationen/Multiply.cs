using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalc
{
    public class Multiply : Results
    {
        void Multiplizieren(int z1, int z2)
        {
            result = z1 * z2;
        }
        void Multiplizieren(double z1, double z2)
        {
            result = z1 * z2;
        }
        void Multiplizieren(float z1, float z2)
        {
            result = z1 * z2;
        }
    }
}
