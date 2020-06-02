namespace Command
{
    public class DrawCanvas : IDrawble
    {
        private int radius = 6;
        private MacroCommand history;

        public DrawCanvas (int width, int height, MacroCommand history)
        {
            this.history = history;
        }
        public void Paint ()
        {

        }
        public void Draw (int x, int y)
        {

        }
    }
}