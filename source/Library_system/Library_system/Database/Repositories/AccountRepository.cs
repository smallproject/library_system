using System;
using System.Linq;

namespace Library_system.Database.Repositories
{

    //account class repository for reading database
    interface IAccountRepository
    {
        IQueryable<Account> GetMemberById(string id);
        bool FindMember(string code);

        Account Register(string firstname, string lastname, DateTime birthdate,
            string gender, string mobileno, string email, string username, string password);


        string GetNewId(string code);
    }

    class AccountRepository : IAccountRepository
    {
        private readonly LibrarySystemContext _dbContext;

        public AccountRepository()
        {
            _dbContext = new LibrarySystemContext();
        }
        public IQueryable<Account> GetMemberById(string id)
        {
            return from r in _dbContext.Accounts
                   where r.Id == id
                   select r;
        }

        public bool FindMember(string code)
        {
            throw new NotImplementedException();
        }

        public Account Register(string firstname, string lastname, DateTime birthdate, string gender, string mobileno, string email,
            string username, string password)
        {
            Account newAccount = new Account()
            {

            };


            //throw new System.NotImplementedException();
            return null;
        }

        public string GetNewId(string code)
        {
            IIndexRepository repo = new IndexRepository();
            var index = repo.GetMemberByCode("nca");

            return $"{index.Code}{string.Format("{0:000000}", index.CurrentIndex + 1) }";
        }
    }
}
