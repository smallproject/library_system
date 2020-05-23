using System.Linq;

namespace Library_system.Database.Repositories
{
    interface IUserRepository
    {
        User GetMemberById(int id);
        bool FindMember(int id);
        bool FindMember(string username, string password);
    }
    class UserRepository : IUserRepository
    {
        //public User GetMemberById { get; set; }
        //public bool FindMember { get; set; }

        private readonly LibrarySystemContext _dbContext;

        public UserRepository()
        {
            _dbContext = new LibrarySystemContext();
        }
        
        User IUserRepository.GetMemberById(int id)
        {
            return _dbContext.Users.FirstOrDefault(r => r.Id == id.ToString());
        }

        bool IUserRepository.FindMember(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool FindMember(string username, string password)
        {
            //_dbContext.Users.Count(r => r.Username == username && r.Password == password);

            //var member = from r in _dbContext.Users
            //    where r.Username == username && r.Password == password
            //    select r;

            var member = _dbContext.Users.Count(r => r.Username == username && r.Password == password);

            if (member.Equals(1))
            {
                return true;
            }

            return false;
        }
    }
}
