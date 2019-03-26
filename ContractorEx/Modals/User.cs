using System;
namespace ContractorEx.Modals
{
    public class User
    {

        public User() { }

        public User(string last, string first, bool stayLogged, string email)
        {
            NameLast = last;
            NameFirst = first;
            //StayLoggedIn = stayLogged;
            AddressEmail = email;

        }

        public string NameFirst
        {
            get;
            set;
        }

        public string NameLast
        {
            get;
            set;
        }

        public bool LoggedIn
        {
            get;
            set;
        }

        public string AddressEmail
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

    }

}
