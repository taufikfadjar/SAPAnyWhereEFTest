namespace MirokuExample.CodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DBA.EdmProducts")]
    public partial class EdmProduct
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(128)]
        public string CategoryID { get; set; }

        public virtual EdmCategory EdmCategory { get; set; }
    }
}
