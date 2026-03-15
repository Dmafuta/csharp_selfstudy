namespace SelfStudy
{
    public class Banking
    {
        User _user;
        string? _accountnumber;
        string? _accountname;

        public Banking()
        {
            _user = new User();
            _accountnumber = string.Empty;
            _accountname = string.Empty;
        }

        public Banking(User user, string accountnumber, string accountname)
        {
            this._user = new User();
            this._accountnumber = accountnumber;
            this._accountname = accountname;
        }

        public void SetAccountUser(User user) { this._user = user; }
        public string GetAccountUser(string user) { return user; }
        public void SetAccountName(string accountname) { this._accountname = accountname; }
        public string? GetAccountName() { return this._accountname; }
        public void SetAccountNumber(string accounnumber) { this._accountnumber = accounnumber; }
        public string? GetAccountNumber() { return this._accountnumber; }

    }
}
