#if !MYCALCULATOR
#define MYCALCULATOR

namespace MyCalculator
{
<<<<<<< HEAD
    using System;
    public class Calculator : ICalculator {
        public double Add (double a, double b) {
            return a + b;
        }

        public double Sub (double a, double b) {
            return Add (a, -b);
        }
   
	public int Add (double a, double b) {
		return (int)(a + b);
	}

	public int Sub (double a, double b) {
		return Add (a, -b);
	}
	}
>>>>>>> deeabbb... Avoid calculation accuracy
}
#endif
