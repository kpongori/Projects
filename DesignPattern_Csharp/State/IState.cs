namespace State
{
    public interface IState
    {
        void DoClock (IContext context, int hour);
        void DoUse (IContext context);
        void DoAlarm (IContext context);
        void DoPhone (IContext context);
    }
}