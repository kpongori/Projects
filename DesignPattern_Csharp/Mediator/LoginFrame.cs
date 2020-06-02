namespace Mediator
{
    public class LoginFrame : IMediator
    {
        private ColleagueCheckbox checkGuest;
        private ColleagueCheckbox checkLogin;
        private ColleagueTextField textUser;
        private ColleagueTextField textPass;
        private ColleagueButton buttonOk;
        private ColleagueButton buttonCancel;

        public LoginFrame (string title)
        {
            CreateColleagues ();
        }
        public void CreateColleagues ()
        {
            checkGuest = new ColleagueCheckbox ("Guest");
            checkLogin = new ColleagueCheckbox ("Login");
            textUser = new ColleagueTextField ("", 10);
            textPass = new ColleagueTextField ("", 10);
            buttonOk = new ColleagueButton ("OK");
            buttonCancel = new ColleagueButton ("Cancel");
            checkGuest.SetMediator (this);
            checkLogin.SetMediator (this);
            textUser.SetMediator (this);
            textPass.SetMediator (this);
            buttonOk.SetMediator (this);
            buttonCancel.SetMediator (this);
        }
        public void ColleagueChanged ()
        {

        }
        public void UserPassChanged ()
        {

        }
    }
}