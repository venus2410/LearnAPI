using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Data
{
    public class MyDBContext:DbContext      
    {
        public MyDBContext(DbContextOptions<MyDBContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DemoAPI;Integrated Security=True;TrustServerCertificate=true;");
        }
        public DbSet<HangHoa> HangHoas { get; set;}
        public DbSet<LoaiHang> LoaiHangs { get; set;}
    }
}
