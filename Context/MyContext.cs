using fullCalandar.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace fullCalandar.Context
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<CalendarInfo> CalandarInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
