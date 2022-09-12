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

            if (IsDivisibleBy(n, 5))
            {
                result.Add("Buzz");
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