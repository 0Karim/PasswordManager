using PasswordManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Domain.Entities
{
    public class Login : AuditableEntity
    {
        public Login(string username , string password)
        {
            UserName = username;
            Password = password;
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
