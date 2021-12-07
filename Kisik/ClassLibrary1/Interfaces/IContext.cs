using Kisik.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kisik.DataAccess.Core.Interfaces
{
    public interface IContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<VirtualExpenseRto> VirtualExpenses { get; set; }
        DbSet<RejectExpenceRto> RejectExpences { get; set; }
        DbSet<AcceptExpenseRto> AcceptExpenses { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
