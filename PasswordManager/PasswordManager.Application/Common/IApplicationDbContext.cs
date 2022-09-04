using Microsoft.EntityFrameworkCore;
using PasswordManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Application.Common
{
    public interface IApplicationDbContext
    {
        public DbSet<Login> Logins { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
