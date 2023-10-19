using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace repair_management_backend.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
    }
}
