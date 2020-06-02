namespace Mediator
{
    public class ColleagueCheckbox : IColleague
    {
        private IMediator mediator;

        public ColleagueCheckbox (string caption)
        {

        }
        public void SetMediator (IMediator mediator)
        {
            this.mediator = mediator;
        }
        public void SetColleagueEnabled (bool enabled)
        {

        }
        public void ItemStateChanged ()
        {
            mediator.ColleagueChanged ();
        }
    }
}