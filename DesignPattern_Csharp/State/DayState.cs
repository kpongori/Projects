namespace State
{
    public class DayState : IState
    {
        private static DayState instance = new DayState ();

        private DayState ()
        {

        }
        public static IState GetInstance ()
        {
            return instance;
        }
        public void DoClock (IContext context, int hour)
        {
            if (hour < 9 || 17 <= hour)
            {
                context.ChangeState (NightState.GetInstance ());
            }
        }
        public void DoUse (IContext context)
        {
            context.RecordLog ("金庫使用(昼間)");
        }
        public void DoAlarm (IContext context)
        {
            context.CallSecurityCenter ("非常ベル(昼間)");
        }
        public void DoPhone (IContext context)
        {
            context.CallSecurityCenter ("通常の通話(昼間)");
        }
        public override string ToString ()
        {
            return "[昼間]";
        }
    }
}