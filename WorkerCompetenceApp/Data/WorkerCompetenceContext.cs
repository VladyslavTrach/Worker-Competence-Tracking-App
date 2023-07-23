using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerCompetenceApp.Models;

namespace WorkerCompetenceApp.Data
{
    internal class WorkerCompetenceContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<SkillSet> SkillSets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-M4R959L\TRACHVLADYSLAV;Initial Catalog=WorkerCompetenceApp;Integrated Security=True;Encrypt=False");
        }
    }
}
