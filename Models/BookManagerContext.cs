using System.Data.Entity;

namespace Btlab4.Models
{
    public partial class BookManagerContext : DbContext
    {
        public BookManagerContext()
            : base("name=BookManagerContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
