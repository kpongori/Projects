namespace ChainOfResponsibility
{
    public class SpecialSupport : Support
    {
        private int number;

        public SpecialSupport (string name, int number) : base (name)
        {
            this.number = number;
        }
        protected override bool Resolve (Trouble trouble)
        {
            if (trouble.GetNumber () == number)
            {
                return true;
            }
            return false;
        }
    }
}