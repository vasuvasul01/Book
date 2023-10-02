using Book.API.Modal;
using Microsoft.EntityFrameworkCore;

namespace Book.API.DatabaseContext
{
    public class DBContext : DbContext
    {
        public class OptionBuild
        {
            public OptionBuild()
            {
                OpsBuilder = new DbContextOptionsBuilder<DBContext>();
                OpsBuilder.UseSqlServer(SQLConnection.SqlConnection, OpsBuilder => OpsBuilder.EnableRetryOnFailure());
                DbOptions = OpsBuilder.Options;
            }
            public DbContextOptionsBuilder<DBContext> OpsBuilder { get; set; }
            public DbContextOptions<DBContext> DbOptions { get; set; }
        }
        public static OptionBuild ops = new();

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<tbl_Book> Book { get; set; }
    }
}
