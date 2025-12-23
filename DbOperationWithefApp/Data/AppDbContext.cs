using Microsoft.EntityFrameworkCore;
namespace DbOperationWithefApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
