using System;

namespace Library_system.Database.Repositories
{
    interface IIndexRepository
    {
        Index GetMemberByCode(string code);
        bool FindMember(string code);
    }
    class IndexRepository : IIndexRepository
    {
        public Index GetMemberByCode(string code)
        {
            throw new NotImplementedException();
        }

        public bool FindMember(string code)
        {
            throw new NotImplementedException();
        }
    }
}
