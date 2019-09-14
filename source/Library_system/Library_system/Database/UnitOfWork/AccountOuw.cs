﻿using System;

namespace Library_system.Database.UnitOfWork
{
    interface IAccountOuw : IBase
    {
        Account Account { get; set; }
    }

    class AccountOuw : IAccountOuw
    {
        public bool Create()
        {
            using (dbContext = new LibrarySystemContext())
            {
                try
                {
                    dbContext.Accounts.Add(Account);
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

        private LibrarySystemContext dbContext;
        public Account Account { get; set; }
    }
}