using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entity
{
    public partial class StudentContextDB : DbContext
    {
        public StudentContextDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
