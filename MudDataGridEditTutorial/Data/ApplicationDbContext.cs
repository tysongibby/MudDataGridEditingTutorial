using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MudDataGridEditTutorial.Data.Models;

namespace MudDataGridEditTutorial.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext() 
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }        
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
    }
}