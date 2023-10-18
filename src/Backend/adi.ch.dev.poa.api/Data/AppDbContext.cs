using Microsoft.EntityFrameworkCore;

namespace adi.ch.dev.poa.api.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        { 
            
        }
    }
}
