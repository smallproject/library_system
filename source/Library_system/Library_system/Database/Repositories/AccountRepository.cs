namespace Library_system.Database.Repositories
{

    //account class repository for reading database
    interface IAccountRepository
    {
        Account GetMemberById { get; set; }
        bool FindMember { get; set; }
    }

    class AccountRepository : IAccountRepository
    {
        public Account GetMemberById { get; set; }
        public bool FindMember { get; set; }
    }
}
