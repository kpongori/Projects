namespace ChainOfResponsibility
{
    public class LimitSupport : Support
    {
        private int limit;

        public LimitSupport (string name, int limit) : base (name)
        {
            this.limit = limit;
        }
        protected override bool Resolve (Trouble trouble)
        {
            if (trouble.GetNumber () < limit)
            {
                return true;
            }
            return false;
        }
    }
}