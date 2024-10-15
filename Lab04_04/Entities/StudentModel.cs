using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab04_04.Entities
{
    public partial class StudentModel : DbContext
    {
        public StudentModel()
            : base("name=StudentModel")
        {
        }

        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
