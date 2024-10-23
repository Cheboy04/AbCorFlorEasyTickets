using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectoTicketsAbCorFlo.Models;

namespace ProjectoTicketsAbCorFlo.Data
{
    public class ProjectoTicketsAbCorFloContext : DbContext
    {
        public ProjectoTicketsAbCorFloContext (DbContextOptions<ProjectoTicketsAbCorFloContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectoTicketsAbCorFlo.Models.Ticket> Ticket { get; set; } = default!;
        public DbSet<ProjectoTicketsAbCorFlo.Models.Usuario> Usuario { get; set; } = default!;
    }
}
