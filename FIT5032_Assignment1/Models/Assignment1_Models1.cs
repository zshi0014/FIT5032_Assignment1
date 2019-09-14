namespace FIT5032_Assignment1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Assignment1_Models1 : DbContext
    {
        public Assignment1_Models1()
            : base("name=Assignment1_Models1")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }


    }
}
