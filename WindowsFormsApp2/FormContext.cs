namespace WindowsFormsApp2
{
    public class FormContext {

        private static FormContext _current;

        public UserLoginModel UserContent { get; set; }

        public static FormContext Current { 
            get {
                if (_current == null)
                {
                    _current = new FormContext();
                }

                return _current;
            } 
        }

        public Form1 FormView { get; private set; }

        public LoginIn LoginInView { get; private set; }

        private FormContext()
        {
            FormView = new Form1();
            LoginInView = new LoginIn();
        }

        public void Logout() {
            Current.FormView.Visible = false;
            Current.LoginInView = new LoginIn();
            Current.LoginInView.Visible = true;
            Current.UserContent = null;
        }
    }
}
