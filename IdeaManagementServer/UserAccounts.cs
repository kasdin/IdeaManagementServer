namespace IdeaManagementServer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_userAccounts")]
    public partial class UserAccounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fld_id { get; set; }

        [StringLength(50)]
        public string fld_username { get; set; }

        [StringLength(50)]
        public string fld_password { get; set; }

        public int? fld_loginType { get; set; }
    }
}
