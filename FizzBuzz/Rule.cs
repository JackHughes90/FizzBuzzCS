namespace FizzBuzz
{
    public class Rule
    {
        private int divisor;

        public Rule(int divisor)
        {
            this.divisor = divisor;
        }

        protected virtual List<string> ApplyRule(List<string> list)
        {
            return list;
        }

        public List<string> CheckAndApply(int n, List<string> list)
        {
            if (n % divisor == 0)
            {
                return ApplyRule(list);
            }
            return list;
        }
    }
}
