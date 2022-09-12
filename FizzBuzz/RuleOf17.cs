namespace FizzBuzz
{
    public class RuleOf17
    {
        public static List<string> ModifyList(List<string> list, int n)
        {
            if (DivideBy.IsDivisibleBy(n, 17))
            {
                list.Reverse();
            }
            
            return list;
        }
    }
}