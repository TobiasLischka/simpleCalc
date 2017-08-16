using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Calculator
    {
        private Calculate _calculate = new Calculate();

        private Dictionary<string, Action<string, string>> _calculator = new Dictionary<string, Action<string, string>>();

        public bool isInteger = false;
        public bool isDouble = false;
        public bool isFloat = false;

        public void RunCalculate()
        {
            _calculator = new Dictionary<string, Action<string, string>>()
            {
                ["+"] = (t1, t2) => { CalculatePlus(t1, t2); },
                ["-"] = (t1, t2) => { CalculateMinus(t1, t2); },
                ["*"] = (t1, t2) => { CalculateMal(t1, t2); },
                ["/"] = (t1, t2) => { CalculateGeteilt(t1, t2); }
            };
            var val1 = "";

            while (val1.ToLower() != "quit")
            {
                Console.Write(": ");
                val1 = Console.ReadLine();
                Console.CursorTop = 0;
                Console.CursorLeft = val1.Length + 3;
                ConsoleKeyInfo op = Console.ReadKey();
                Console.Write(" ");
                var val2 = Console.ReadLine();

                _calculator[op.KeyChar.ToString()](val1, val2);

                Console.CursorTop = 0;
                Console.CursorLeft = val1.Length + 3 + val2.Length + 2;

                Console.WriteLine($" = {_calculate.result}");
                Console.WriteLine();
            }
        }
        public void CalculatePlus(string val1, string val2)
        {
            if (int.TryParse(val1, out int intResult) && int.TryParse(val2, out int intResult2))
                _calculate.Plus(intResult, intResult2);

            if (double.TryParse(val1, out double doubleResult) && double.TryParse(val2, out double doubleResult2))
                _calculate.Plus(doubleResult, doubleResult2);
        }
        public void CalculateMinus(string val1, string val2)
        {
            if (int.TryParse(val1, out int intResult) && int.TryParse(val2, out int intResult2))
                _calculate.Substrahieren(intResult, intResult2);

            if (double.TryParse(val1, out double doubleResult) && double.TryParse(val2, out double doubleResult2))
                _calculate.Substrahieren(doubleResult, doubleResult2);
        }
        public void CalculateMal(string val1, string val2)
        {
            if (int.TryParse(val1, out int intResult) && int.TryParse(val2, out int intResult2))
                _calculate.Multiplizieren(intResult, intResult2);

            if (double.TryParse(val1, out double doubleResult) && double.TryParse(val2, out double doubleResult2))
                _calculate.Multiplizieren(doubleResult, doubleResult2);
        }
        public void CalculateGeteilt(string val1, string val2)
        {
            if (int.TryParse(val1, out int intResult) && int.TryParse(val2, out int intResult2))
                _calculate.Divisionen(intResult, intResult2);

            if (double.TryParse(val1, out double doubleResult) && double.TryParse(val2, out double doubleResult2))
                _calculate.Divisionen(doubleResult, doubleResult2);
        }
    }
}

