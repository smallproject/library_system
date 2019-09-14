using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system.Database
{
    interface IAccount
    {
        string Id { get; set; }
        string User { get; set; }
        string Password { get; set; }
        DateTime Created { get; set; }
    }

    class Account:IAccount
    {
        public string Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
    }
}
