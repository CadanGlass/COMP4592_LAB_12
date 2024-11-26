using Microsoft.EntityFrameworkCore;
using SchoolLibrary;

namespace StudentGrpcService.Data;

public class SchoolDbContext : DbContext
{
    public DbSet<Student> Students => Set<Student>();

    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options) { }
} 