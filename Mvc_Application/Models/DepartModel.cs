namespace Mvc_Application.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DepartModel : DbContext
    {
        public DepartModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.Grocery_dept)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Bakery_dept)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Price_of_Product)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.Person_Name)
                .IsUnicode(false);
        }
    }
}
