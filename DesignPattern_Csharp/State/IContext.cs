namespace State
{
    public interface IContext
    {
        void SetClock (int hour);
        void ChangeState (IState state);
        void CallSecurityCenter (string msg);
        void RecordLog (string msg);
    }
}