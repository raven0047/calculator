#if !MYCALCULATOR
#define MYCALCULATOR

namespace MyCalculator
{
    using System;
    public class Calculator : ICalculator {
        public int Add (int a, int b) {
            return a + b;
        }

        public int Sub (int a, int b) {
            return Add (a, -b);
        }
    }
}
#endif