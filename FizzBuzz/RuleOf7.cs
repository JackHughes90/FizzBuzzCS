namespace FizzBuzz
{
    public class RuleOf7
    {
        public static List<string> ModifyList(List<string> list, int n)
        {
            if (DivideBy.IsDivisibleBy(n, 7))
            {
                list.Add("Bang");
            }
            
            return list;
        }
    }
}