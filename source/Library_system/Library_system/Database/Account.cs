using System;
using System.Collections;

namespace Library_system.Database
{
    interface IAccount
    {
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
        string Gender { get; set; }
        string MobileNumber { get; set; }
        string Email { get; set; }
    }
    class Account : IAccount, IEnumerable
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }

        public IEnumerator GetEnumerator()
        {
            //needs to be created to read class value
            throw new NotImplementedException();
        }
    }
}
