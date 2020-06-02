namespace Decorator
{
    public class StringDisplay : Display
    {
        private string str;

        public StringDisplay (string str)
        {
            this.str = str;
        }
        public override int GetColumns ()
        {
            return str.Length;
        }
        public override int GetRows ()
        {
            return 1;
        }
        public override string GetRwoText (int row)
        {
            if (row == 0)
            {
                return str;
            }
            return null;
        }
    }
}