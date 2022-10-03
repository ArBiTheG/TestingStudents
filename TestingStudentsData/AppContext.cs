using System.Data.Entity;

namespace TestingStudentsData
{
    public class AppContext : DbContext
    {
        public DbSet<Tables.Chapter> Chapters { get; set; }
        public AppContext() : base("DefaultConnection") { }
    }
}
