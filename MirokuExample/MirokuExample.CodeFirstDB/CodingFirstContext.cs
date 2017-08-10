using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirokuExample.CodeFirstDB
{
    [Table("EdmCategories", Schema = "DBA")]
    public class Category
    {
        public string CategoryID { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    [Table("EdmProducts", Schema = "DBA")]
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }
        public string CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }

    [Table("EdmSuppliers", Schema = "DBA")]
    public class Supplier
    {
        [Key]
        public string SupplierCode { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }
    }

    public class CodingFirstContext : DbContext
    {
        public CodingFirstContext() : base() { }
        public CodingFirstContext(string connStr) : base(connStr) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().Property(s => s.Name).IsRequired();
        }
    }
}
