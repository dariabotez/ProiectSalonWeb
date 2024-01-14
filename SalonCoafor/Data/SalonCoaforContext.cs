using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalonCoafor.Models;

namespace SalonCoafor.Data
{
    public class SalonCoaforContext : DbContext
    {
        public SalonCoaforContext (DbContextOptions<SalonCoaforContext> options)
            : base(options)
        {
        }

        public DbSet<SalonCoafor.Models.Appointment> Appointment { get; set; } = default!;

        public DbSet<SalonCoafor.Models.Service>? Service { get; set; }

        public DbSet<SalonCoafor.Models.Stylist>? Stylist { get; set; }

        public DbSet<SalonCoafor.Models.User>? User { get; set; }
    }
}
