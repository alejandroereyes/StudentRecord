using Microsoft.EntityFrameworkCore;
using StudentRecordApp.Domain;

namespace StudentRecordApp.Data
{
    public class StudentRecordContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Course> Courses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = StudentRecordData; Trusted_Connection = True;"
            );
        }
    }
}