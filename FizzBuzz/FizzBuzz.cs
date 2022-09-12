namespace FizzBuzz
{
    public class FizzBuzz
    {
        private static bool IsDivisibleBy(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }
        public string FizzBuzzFor(int n)
        {
            List<String> result = new List<string>();

            if (IsDivisibleBy(n, 3))
            {
                result.Add("Fizz");
            }

            if (IsDivisibleBy(n, 13))
            {
                result.Add("Fezz");
            }

            if (IsDivisibleBy(n, 5))
            {
                result.Add("Buzz");
            }

            if (IsDivisibleBy(n, 7))
            {
                result.Add("Bang");
            }

            if (IsDivisibleBy(n, 11))
            {
                result.Clear();
                if (IsDivisibleBy(n, 13))
                {
                    result.Add("Fezz");
                }
                result.Add("Bong");
            }

            if (IsDivisibleBy(n, 17))
            {
                result.Reverse();
            }

            string resultString = String.Join("", result);

            if (!result.Any())
            {
                return n.ToString();
            }
            else
            {
                return resultString;
            }
        }
    }
}