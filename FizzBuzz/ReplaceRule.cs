namespace FizzBuzz
{
    public class ReplaceRule : Rule
    {
        private string stringToReplaceWith;

        public ReplaceRule(int divisor, string stringToReplaceWith) : base(divisor)
        {
            this.stringToReplaceWith = stringToReplaceWith;
        }

        protected override List<string> ApplyRule(List<string> list)
        {
            list.Clear();
            list.Add(stringToReplaceWith);
            return list;
        }
    }
}
