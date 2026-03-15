namespace SelfStudy
{
    public class User
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _phonenumber;
        DateTime _registrationdate;

        public User() 
        { 
            _firstname = string.Empty;
            _lastname = string.Empty;
            _phonenumber = string.Empty;
            _email = string.Empty;
            _registrationdate = DateTime.Today;
        }

        public User(string firstname, string lastname, string email, string phonenumber, DateTime registrattiondate)
        {
            this._firstname = firstname;
            this._lastname = lastname;
            this._email = email;
            this._phonenumber = phonenumber;
            this._registrationdate = registrattiondate;
        }

        public void SetFirstName(string firstname){ this._firstname = firstname; }
        public string GetFirstName(){ return this._firstname; }
        public void SetLastName(string lastname) { this._lastname = lastname; }
        public string GetLastName() { return this._lastname; }
        public void SetEmail(string email){ this._email = email; } 
        public string GetEmail() { return this._email; }
        public void SetPhoneNumber(string phonenumber) { this._phonenumber = phonenumber;  }
        public string GetPhonenumber() { return this._phonenumber; }
        public void SetRegistrationDate(DateTime registrationdate) {  this._registrationdate = registrationdate; }
        public DateTime GetRegistrattiondate() { return this._registrationdate; }

        public string ShowFullNames(User user)
        {
            //User user = new User();

            if (user.GetFirstName() != null && user.GetLastName() != null)
            {
               return user.GetFirstName() + " " + user.GetLastName().Trim();
            }
            return string.Empty;
        }

        public List<User> ListAccountUser()
        {
            return new List<User>();
        }
        public override string ToString()
        {
            return string.Format($"\nUser details: " +
                "\n-----------------------------------" +
                "\nFull names: {0}" +
                "\nPhone number: {1}" +
                "\nEmail address: {2}" +
                "\nRegistration Date: {3}",GetFirstName(), GetPhonenumber(), GetEmail(), GetRegistrattiondate());
        }

    }
}
