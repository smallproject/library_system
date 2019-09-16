using System;
using System.Text;
using System.Windows.Forms;

namespace Library_system.Database.UnitOfWork
{
    interface IAccountUow : IBase
    {
        Account Account { get; set; }
        void ReadVarAccount();
    }

    class AccountUow : IAccountUow
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
                    MessageBox.Show(e.Message);
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
        public void ReadVarAccount()
        {
            StringBuilder text = new StringBuilder();

            //needs to created ienumerator for account class
            //to enable foreach loop
            //foreach (var data in Account)
            //{
            //    text.AppendLine(Account.);
            //}

            text.AppendLine(Account.FirstName);
            text.AppendLine(Account.LastName);
            text.AppendLine(Account.BirthDate.ToString());
            text.AppendLine(Account.Gender);
            text.AppendLine(Account.MobileNumber);
            text.AppendLine(Account.Email);

            try
            {
                MessageBox.Show(text.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
