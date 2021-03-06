using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaManagementServer.Models
{
    [Table("tbl_ideas")]
    public partial class Ideas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int fld_id { get; set; }

        [StringLength(50)]
        public string fld_title { get; set; }

        [Column(TypeName = "text")]
        public string fld_description { get; set; }

        public int? fld_effortScale { get; set; }

        public int? fld_impactScale { get; set; }

        [StringLength(100)]
        public string fld_fileURL { get; set; }

        public int? fld_employeeNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fld_date { get; set; }
    }
}
