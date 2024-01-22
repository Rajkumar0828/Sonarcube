using Microsoft.EntityFrameworkCore;

namespace APICrudServer.Data
{
   public class ApiDbContext :DbContext
   {
         public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
         {

         }

     public DbSet<Mobile> Mobiles { get; set; }
   }
}