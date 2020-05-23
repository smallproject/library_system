using Library_system.Database.Repositories;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Library_system.Database.UnitOfWork
{
    interface IIndexUow : IBase
    {
        Index Index { get; set; }
        Index Get(string code);
        bool IncrementCurrentIndex(string code);
    }

    class IndexUow : IIndexUow
    {
        public IndexUow()
        {
            dbContext = new LibrarySystemContext();
        }

        public bool Create()
        {
            using (dbContext)
            {
                try
                {
                    dbContext.Indices.Add(Index);
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    throw new NotImplementedException();
                }
            }

            return true;
        }

        public bool Update()
        {
            using (dbContext)
            {
                try
                {
                    var entry = dbContext.Entry(Index);
                    var test = entry.State = EntityState.Modified;
                    //MessageBox.Show(test.ToString());
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return true;
        }

        public bool Delete()
        {
            using (dbContext)
            {
                try
                {
                    var entry = dbContext.Entry(Index);
                    entry.State = EntityState.Deleted;
                    dbContext.SaveChanges();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return true;
        }

        public Index Index { get; set; }
        public Index Get(string code)
        {
            return dbContext.Indices.FirstOrDefault(r => r.Code == code);
        }

        public bool IncrementCurrentIndex(string code)
        {
            IIndexRepository repo = new IndexRepository();
            Index = repo.GetMemberByCode(code);
            Index.CurrentIndex++;

            return Update();
        }

        private readonly LibrarySystemContext dbContext;
    }
}
