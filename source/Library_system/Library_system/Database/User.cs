using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system.Database
{
    interface IUser
    {
        string Id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        DateTime Created { get; set; }
    }

    class User:IUser
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
    }
}
