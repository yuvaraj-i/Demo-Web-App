using Microsoft.EntityFrameworkCore;

namespace WebTraningDemoApp.Models
{
    public class StudentModelContext : DbContext
    {


        public StudentModelContext(DbContextOptions<StudentModelContext> options) : base(options)
        {

        }

        public DbSet<StudentModel> Students { get; set; }
    }
}
