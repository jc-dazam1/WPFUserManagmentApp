using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagmentApp.Models;

namespace UserManagmentApp.Utilities
{
    public class DbContextOptionsFactory
    {
        public static DbContextOptions<AppDbContext> BuildOptions()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            optionsBuilder.UseNpgsql(connectionString);
            return optionsBuilder.Options;
        }
    }
}
