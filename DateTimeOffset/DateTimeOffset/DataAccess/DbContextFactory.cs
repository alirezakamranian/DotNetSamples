using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeOffset.DataAccess
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql("Host=nanaga-parbat.liara.cloud:32930;Username=root;Password=tt3gk25cYJqdty6kKFAqAOfA;Database=DateTimeOffset;Include Error Detail=true");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
