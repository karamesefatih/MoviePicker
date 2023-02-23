using Core.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    //This is the part where tables and connection strings store,İts basically our database model
    public class MoviePickerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseNpgsql(@"Host=localhost;Port=5442;Username=postgres;Password=saadet2000;Database=MoviePicker");
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<WatchList> List { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRolePairing> UserRolePairing { get; set; }
    }
}
