using Kisik.DataAccess.Core.Interfaces;
using Kisik.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisik.DataAccess.DBContexts
{
    public class AlbinaContext : DbContext, IContext
    {
        public AlbinaContext(DbContextOptions<AlbinaContext> options) : base(options)
        {

        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<VirtualExpenseRto> VirtualExpenses { get; set; }
        public DbSet<RejectExpenceRto> RejectExpences { get; set; }
        public DbSet<AcceptExpenseRto> AcceptExpenses { get; set; }
    }
}
