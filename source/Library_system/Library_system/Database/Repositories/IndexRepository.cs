using System.Linq;

namespace Library_system.Database.Repositories
{
    interface IIndexRepository
    {
        Index GetMemberByCode(string code);
        bool FindMember(string code);
    }
    class IndexRepository : IIndexRepository
    {
        private readonly LibrarySystemContext _dbContext;
        public IndexRepository()
        {
            _dbContext = new LibrarySystemContext();
        }

        public Index GetMemberByCode(string code)
        {
            return _dbContext.Indices.FirstOrDefault(r => r.Code == code);
        }

        public bool FindMember(string code)
        {
            var member = _dbContext.Indices.Count(r => r.Code == code);

            if (member.Equals(1))
            {
                return true;
            }

            return false;
        }
    }
}
