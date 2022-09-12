namespace FizzBuzz
{
    public class RuleOf3
    {
        public static List<string> ModifyList(List<string> list, int n)
        {
            if (DivideBy.IsDivisibleBy(n, 3))
            {
                list.Add("Fizz");
            }
            
            return list;
        }
    }
}