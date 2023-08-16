using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseApp.Models;

namespace CoursesApp.Data
{
    public class CoursesDbContext : DbContext
    {
        public CoursesDbContext (DbContextOptions<CoursesDbContext> options)
            : base(options)
        {
        }

        public DbSet<CourseApp.Models.Courses> Courses { get; set; } = default!;
    }
}
