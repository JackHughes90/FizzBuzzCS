namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string FizzBuzzFor(int n)
        {            
            List<String> result = new List<string>();

            RuleOf3.ModifyList(result, n);
            RuleOf13.ModifyList(result, n);
            RuleOf5.ModifyList(result, n);
            RuleOf7.ModifyList(result, n);
            RuleOf11.ModifyList(result, n);
            RuleOf17.ModifyList(result, n);

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