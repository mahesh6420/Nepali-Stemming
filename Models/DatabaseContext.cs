using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design.Internal;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Stemming.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        
        public DbSet<RootModel> Roots { get; set; }
        public DbSet<SuffixModel> Suffixes { get; set; }
        public DbSet<InputModel> Inputs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RootModel>().ToTable("tblRoot");
            modelBuilder.Entity<SuffixModel>().ToTable("tblSuffix");
            modelBuilder.Entity<InputModel>().ToTable("tblInput");
            modelBuilder.Entity<StopWordModel>().ToTable("tblStopword");

           modelBuilder.Entity<InputModel>().HasOne<RootModel>(r => r.Root).WithMany();
//            modelBuilder.Entity<SuffixModel>().HasMany<InputModel>(s => s.Inputs).WithOne();
                
            base.OnModelCreating(modelBuilder);
        }
    }
}