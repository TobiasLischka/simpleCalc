using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Calculate : Results, IPlus, IMultiply, ISubstract, IDivide
    {

        public int Divisionen(int z1, int z2)
        {
            result = z1 / z2;
            return (int)result;
        }

        public double Divisionen(double z1, double z2)
        {
            result = z1 / z2;
            return (double)result;
        }

        public float Divisionen(float z1, float z2)
        {
            result = z1 / z2;
            return (float)result;
        }

        public int Multiplizieren(int z1, int z2)
        {
            result = z1 * z2;
            return (int)result;
        }

        public double Multiplizieren(double z1, double z2)
        {
            result = z1 * z2;
            return (double)result;
        }

        public float Multiplizieren(float z1, float z2)
        {
            result = z1 * z2;
            return (float)result;
        }

        public int Plus(int z1, int z2)
        {
            result = z1 + z2;
            return (int)result;
        }

        public double Plus(double z1, double z2)
        {
            result = z1 + z2;
            return (double)result;
        }

        public float Plus(float z1, float z2)
        {
            result = z1 + z2;
            return (float)result;
        }

        public int Substrahieren(int z1, int z2)
        {
            result = z1 - z2;
            return (int)result;
        }

        public double Substrahieren(double z1, double z2)
        {
            result = z1 - z2;
            return (double)result;
        }

        public float Substrahieren(float z1, float z2)
        {
            result = z1 - z2;
            return (float)result;
        }
    }
}
