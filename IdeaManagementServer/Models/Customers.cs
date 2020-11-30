using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaManagementServer.Models
{
    [Table("tbl_customers")]
    public partial class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

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
