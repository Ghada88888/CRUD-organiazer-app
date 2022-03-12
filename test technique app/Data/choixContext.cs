using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test_technique_app.models;

namespace test_technique_app.Data
{
    public class choixContext : DbContext
    {
        public choixContext (DbContextOptions<choixContext> options)
            : base(options)
        {
        }

        public DbSet<test_technique_app.models.choix> choix { get; set; }
    }
}
