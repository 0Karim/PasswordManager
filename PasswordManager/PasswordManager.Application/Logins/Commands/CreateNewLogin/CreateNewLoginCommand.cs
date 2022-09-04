using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Application.Logins.Commands.CreateNewLogin
{
    public class CreateNewLoginCommand : IRequest<int>
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
