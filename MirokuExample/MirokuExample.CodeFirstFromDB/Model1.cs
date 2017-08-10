namespace MirokuExample.CodeFirstFromDB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<EdmCategory> EdmCategories { get; set; }
        public virtual DbSet<EdmProduct> EdmProducts { get; set; }
        public virtual DbSet<EdmSupplier> EdmSuppliers { get; set; }
        public virtual DbSet<Hello> Helloes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
