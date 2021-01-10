namespace MyCalculator
{
    using System;
    public class Calculator : ICalculator {
        public int Add (int a, int b) {
            return a + b;
        }
    }
}