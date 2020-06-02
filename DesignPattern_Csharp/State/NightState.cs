namespace State
{
    public class NightState : IState
    {
        private static NightState instance = new NightState ();

        private NightState ()
        {

        }
        public static IState GetInstance ()
        {
            return instance;
        }
        public void DoClock (IContext context, int hour)
        {
            if (9 <= hour && hour < 17)
            {
                context.ChangeState (DayState.GetInstance ());
            }
        }
        public void DoUse (IContext context)
        {
            context.RecordLog ("非常：夜間の金庫使用！");
        }
        public void DoAlarm (IContext context)
        {
            context.CallSecurityCenter ("非常ベル(夜間)");
        }
        public void DoPhone (IContext context)
        {
            context.CallSecurityCenter ("夜間の通話録音");
        }
        public override string ToString ()
        {
            return "[夜間]";
        }
    }
}