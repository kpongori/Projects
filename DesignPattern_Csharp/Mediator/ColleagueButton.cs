namespace Mediator
{
    public class ColleagueButton : IColleague
    {
        private IMediator mediator;

        public ColleagueButton (string caption)
        {

        }
        public void SetMediator (IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void SetColleagueEnabled (bool enabled)
        {

        }
    }
}