namespace FizzBuzz
{
    public class RuleOf5
    {
        public static List<string> ModifyList(List<string> list, int n)
        {
            if (DivideBy.IsDivisibleBy(n, 5))
            {
                list.Add("Buzz");
            }
            
            return list;
        }
    }
}