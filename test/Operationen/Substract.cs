using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalc
{
    public class Substract : Results
    {
        void Substrahieren(int z1, int z2)
        {
            result = z1 - z2;
        }
        void Substrahieren(double z1, double z2)
        {
            result = z1 - z2;
        }
        void Substrahieren(float z1, float z2)
        {
            result = z1 - z2;
        }
    }
}
