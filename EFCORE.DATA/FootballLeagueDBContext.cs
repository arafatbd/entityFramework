using System;
using Microsoft.EntityFrameworkCore;
using EFCORE.DOMAIN;
using System.Xml.Linq;

namespace EFCORE.DATA
{
	public class FootballLeagueDBContext: DbContext
	{
        private string DbPath;

        public FootballLeagueDBContext()
        {
            var folder = Environment.SpecialFolder.ApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Combine(path, "FootballLeague_EfCore.db");
        }
		public DbSet<Team> teams { get; set; }

		public DbSet<Coach> coaches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source=FootballLeague_EfCore.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "Arafat",
                    createdDate = DateTimeOffset.Now.DateTime
                },
                new Team
                {
                    Id = 2,
                    Name = "Hossain",
                    createdDate = DateTimeOffset.Now.DateTime
                }
            );
        }
    }
}

