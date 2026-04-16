
namespace Calculator
{
    public class Operations
    {
        /// <summary>
        /// Two number overloads.
        /// 
        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }

        /// <summary>
        /// List overloads.
        ///
        public static double Add(List<double> numbers)
        {
            double result = 0;
            foreach (double num in numbers) 
            {
                result += num;
            }
            return result;
        }

        public static double Subtract(List<double> numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public static double Multiply(List<double> numbers)
        {
            double result = 1;
            foreach (double num in numbers) 
            {
                result *= num;
            }
            return result;
        }

        public static double Divide(List<double> numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                result /= numbers[i];
            }
            return result;
        }
    }


}
