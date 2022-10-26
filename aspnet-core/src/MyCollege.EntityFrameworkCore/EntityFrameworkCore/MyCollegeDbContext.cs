using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCollege.Authorization.Roles;
using MyCollege.Authorization.Users;
using MyCollege.MultiTenancy;

namespace MyCollege.EntityFrameworkCore
{
    public class MyCollegeDbContext : AbpZeroDbContext<Tenant, Role, User, MyCollegeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyCollegeDbContext(DbContextOptions<MyCollegeDbContext> options)
            : base(options)
        {
        }
    }
}
