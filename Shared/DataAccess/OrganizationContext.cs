using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Data;

namespace MyBlazorApp.Shared.DataAccess
{
    public class OrganizationContext : DbContext
    {
        public virtual DbSet<OrganizationDetails> Organization { get; set; }
        
        public OrganizationContext(DbContextOptions<OrganizationContext> options)
            : base(options){}
    }
}
