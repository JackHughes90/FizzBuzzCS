namespace FizzBuzz
{
    public class AddRule : Rule
    {
        private string stringToAdd;

        public AddRule(int divisor, string stringToAdd) : base(divisor)
        {
            this.stringToAdd = stringToAdd;
        }

        protected override List<string> ApplyRule(List<string> list)
        {
            list.Add(stringToAdd);
            return list;
        }
    }
}
