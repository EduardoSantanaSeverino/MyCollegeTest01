using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyCollege.EntityFrameworkCore
{
    public static class MyCollegeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyCollegeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyCollegeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
