namespace MirokuExample.CodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DBA.Hello")]
    public partial class Hello
    {
        [Key]
        [Column("Hello")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Hello1 { get; set; }
    }
}
