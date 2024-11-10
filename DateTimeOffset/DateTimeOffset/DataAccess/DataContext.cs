using DateTimeOffset.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeOffset.DataAccess
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=nanaga-parbat.liara.cloud:32930;Username=root;Password=tt3gk25cYJqdty6kKFAqAOfA;Database=DateTimeOffset;Include Error Detail=true");
        }

        public DbSet<Order> Orders { get; set; }
    }
}
