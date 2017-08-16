using System;

namespace SimpleCalc
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