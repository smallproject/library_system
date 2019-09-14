namespace Library_system.Database.Repositories
{
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
