using MediatR;
using PasswordManager.Application.Common;
using PasswordManager.Application.Common.Extensions;
using PasswordManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Application.Logins.Commands.CreateNewLogin
{
    public class CreateNewLoginHandler : IRequestHandler<CreateNewLoginCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateNewLoginHandler(IApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<int> Handle(CreateNewLoginCommand request, CancellationToken cancellationToken)
        {
            var login = new Login(request.UserName, request.Password);
            login.Password.Encrypt();
            _context.Logins.Add(login);
            await _context.SaveChangesAsync(cancellationToken);
            return login.Id;
        }
    }
}
