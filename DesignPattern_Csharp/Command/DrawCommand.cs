namespace Command
{
    public class DrawCommand : ICommand
    {
        protected IDrawble drawble;
        private Point position;

        public DrawCommand (IDrawble drawble, Point position)
        {
            this.drawble = drawble;
            this.position = position;
        }
        public void Execute ()
        {
            drawble.Draw (position.x, position.y);
        }
    }
}