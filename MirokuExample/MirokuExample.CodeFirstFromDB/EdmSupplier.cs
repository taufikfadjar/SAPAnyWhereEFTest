namespace MirokuExample.CodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DBA.EdmSuppliers")]
    public partial class EdmSupplier
    {
        [Key]
        public string SupplierCode { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }
    }
}
