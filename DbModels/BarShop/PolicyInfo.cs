using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barunson.DbContext.DbModels.BarShop
{
    public partial class PolicyInfo
    {
        [Key]
        public int Seq { get; set; }

        [StringLength(2)]
        [Unicode(false)]
        public string SalesGubun { get; set; } = "";

        public int CompanySeq { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string AdminName { get; set; } = "";

        [StringLength(200)]
        [Unicode(false)]
        public string Title { get; set; } = "";

        [Unicode(false)]
        public string Contents { get; set; } = "";

        /// <summary>
        /// 섹션 (P:개인정보처리방침 U:이용약관, B:)
        /// </summary>
        [Unicode(false)]
        [StringLength(1)]
        public string PolicyDiv { get; set; } = "P";

        [StringLength(10)]
        [Unicode(false)]
        public string? StartDate { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? EndDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime RegDate { get; set; }

        [StringLength(1)]
        public string? Target { get; set; } = "0";
    }
}
