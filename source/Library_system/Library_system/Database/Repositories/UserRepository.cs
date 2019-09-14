namespace Library_system.Database.Repositories
{
    interface IUserRepository
    {
        User GetMemberById { get; set; }
        bool FindMember { get; set; }
    }
    class UserRepository : IUserRepository
    {
        public User GetMemberById { get; set; }
        public bool FindMember { get; set; }
    }
}
