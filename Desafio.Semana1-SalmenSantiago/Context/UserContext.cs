using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desafio.Semana1_SalmenSantiago.Entities;

namespace Desafio.Semana1_SalmenSantiago.Context
{
    class UserContext : DbContext
    {

        private const string Schema = "Foro";
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\Servidor;Database=UserDb;Integrated Security=True;");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
           
               


        }

        public DbSet<User> Users { get; set; } = null;
        public DbSet<Post> Posts { get; set; } = null;
        public DbSet<Comment> Comments { get; set; } = null;
    }
}
