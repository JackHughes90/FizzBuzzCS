namespace FizzBuzz
{
    public class RuleOf13
    {
        public static List<string> ModifyList(List<string> list, int n)
        {
            if (DivideBy.IsDivisibleBy(n, 13))
            {
                list.Add("Fezz");
            }
            
            return list;
        }
    }
}