namespace Mediator
{
    public class ColleagueTextField : IColleague
    {
        private IMediator mediator;

        public ColleagueTextField (string text, int columns)
        {

        }
        public void SetMediator (IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void SetColleagueEnabled (bool enabled)
        {

        }
        public void TextValueChanged ()
        {
            mediator.ColleagueChanged ();
        }
    }
}