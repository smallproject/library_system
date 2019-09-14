using System;

namespace Library_system.Database.UnitOfWork
{
    //account interface unit of work for database manipulation
    interface IUserOuw : IBase
    {
        User User { get; set; }
    }

    class UserOuw : IUserOuw
    {
        private LibrarySystemContext dbContext;
        public bool Create()
        {
            using (dbContext = new LibrarySystemContext())
            {
                try
                {
                    //dbContext.Accounts.Add(User);
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new NotImplementedException();
                }
            }

            return true;
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public User User { get; set; }
    }
}
