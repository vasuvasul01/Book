using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Book.API.DatabaseContext
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var opsBuilder = new DbContextOptionsBuilder<DBContext>();
            opsBuilder.UseSqlServer(SQLConnection.SqlConnection);
            return new DBContext(opsBuilder.Options);
        }
    }
}
