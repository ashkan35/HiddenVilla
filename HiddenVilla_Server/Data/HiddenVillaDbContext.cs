using Microsoft.EntityFrameworkCore;

namespace HiddenVilla_Server.Data
{
    public class HiddenVillaDbContext:DbContext
    {
        public HiddenVillaDbContext(DbContextOptions<HiddenVillaDbContext> options):base(options)
        {
            
        }

        public DbSet<HotelRoom> HotelRooms { get; set; }
    }
}
