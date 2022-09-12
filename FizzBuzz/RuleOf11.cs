namespace FizzBuzz
{
    public class RuleOf11
    {
        public static List<string> ModifyList(List<string> list, int n)
        {
            if (DivideBy.IsDivisibleBy(n, 11))
            {
                list.Clear();
                if (DivideBy.IsDivisibleBy(n, 13))
                {
                    list.Add("Fezz");
                }
                list.Add("Bong");
            }
            
            return list;
        }
    }
}