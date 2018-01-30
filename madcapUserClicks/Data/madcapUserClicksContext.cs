using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace madcapUserClicks.Models
{
    public class madcapUserClicksContext : DbContext
    {
        public madcapUserClicksContext (DbContextOptions<madcapUserClicksContext> options)
            : base(options)
        {
        }

        public DbSet<madcapUserClicks.Models.User> User { get; set; }
    }
}
