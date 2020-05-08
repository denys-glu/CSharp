using System;
using Microsoft.EntityFrameworkCore;

namespace LoginRegistration.Models
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions options): base(options) {}

        public DbSet<RegisterUser> Users { get; set; }
    }
}