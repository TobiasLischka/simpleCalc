using System;

namespace test
{
    class RechnerMain : Calculator
    {
        static void Main(string[] args)
        {
            var rechner = new Calculator();
            rechner.RunCalculate();
        }
    }
}