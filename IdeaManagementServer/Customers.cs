namespace IdeaManagementServer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("tbl_customers")]
    public partial class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fld_id { get; set; }

        [StringLength(50)]
        public string fld_name { get; set; }

        [StringLength(50)]
        public string fld_mail { get; set; }

        [StringLength(12)]
        public string fld_phoneNo { get; set; }

        [StringLength(50)]
        public string fld_url { get; set; }
    }
}
