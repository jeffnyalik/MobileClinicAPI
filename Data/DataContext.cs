using Microsoft.EntityFrameworkCore;
using MobileClinicAPI.Models;

namespace MobileClinicAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Patients>Patients { get; set; }

    }
}
