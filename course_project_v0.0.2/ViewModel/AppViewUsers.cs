using GalaSoft.MvvmLight;

namespace course_project_v0._0._2.View
{
	class AppViewUsers : ViewModelBase
    {
        public string UserID { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string Email { get; set; }
        public bool admin { get; set; }

        public void AddUser(int _UserID, string _login, string _password, string _Email, bool _admin)
        {
            UserID = "" + _UserID;
            login = _login;
            password = _password;
            Email = _Email;
            admin = _admin;
        }
    }
}
