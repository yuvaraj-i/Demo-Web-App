using Microsoft.EntityFrameworkCore;

namespace WebTraningDemoApp.Models
{
    public class StudentDBContext : DbContext
    {


        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }

        public DbSet<StudentModel> Students { get; set; }
    }
}
