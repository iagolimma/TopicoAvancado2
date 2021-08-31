using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoAsPCore.Model;

namespace ProjetoAsPCore.Data
{
    public class ProjetoAsPCoreContext : DbContext
    {
        public ProjetoAsPCoreContext (DbContextOptions<ProjetoAsPCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoAsPCore.Model.Person> Person { get; set; }
    }
}
