using System;

namespace Library_system.Database.Repositories
{

    //account class repository for reading database
    interface IAccountRepository
    {
        Account GetMemberById { get; set; }
        bool FindMember { get; set; }

        Account Register(string firstname, string lastname, DateTime birthdate,
            string gender, string mobileno, string email, string username, string password);

    }

    class AccountRepository : IAccountRepository
    {
        public Account GetMemberById { get; set; }
        public bool FindMember { get; set; }

        public Account Register(string firstname, string lastname, DateTime birthdate, string gender, string mobileno, string email,
            string username, string password)
        {
            Account newAccount = new Account()
            {

            };


            //throw new System.NotImplementedException();
            return null;
        }
    }
}
