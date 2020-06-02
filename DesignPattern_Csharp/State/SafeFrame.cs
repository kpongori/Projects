using System;
namespace State
{
    public class SafeFrame : IContext
    {
        private IState state = DayState.GetInstance ();

        public SafeFrame (string title)
        {

        }
        public void ActionPerformed ()
        {

        }
        public void SetClock (int hour)
        {
            string clockString = "現在時刻は";
            if (hour < 10)
            {
                clockString += "0" + hour + ":00";
            }
            else
            {
                clockString += hour + ":00";
            }
            Console.WriteLine (clockString);
            state.DoClock (this, hour);
        }
        public void ChangeState (IState state)
        {
            Console.WriteLine (this.state + "から" + state + "へ状態が変化しました。");
            this.state = state;
        }
        public void CallSecurityCenter (string msg)
        {

        }
        public void RecordLog (string msg)
        {

        }
    }
}