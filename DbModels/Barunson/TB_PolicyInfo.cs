using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barunson.DbContext.DbModels.Barunson
{
    /// <summary>
    /// 약관(정책)관리
    /// </summary>
    public partial class TB_PolicyInfo
    {
        [Key]
        public int Seq { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string AdminName { get; set; } = "";

        [StringLength(200)]
        [Unicode(false)]
        public string Title { get; set; } = "";

        [Unicode(false)]
        public string Contents { get; set; } = "";

        /// <summary>
        /// 섹션 (P:개인정보처리방침 U:이용약관)
        /// </summary>
        [Unicode(false)]
        [StringLength(1)]
        public string PolicyDiv { get; set; } = "P";

        [StringLength(10)]
        [Unicode(false)]
        public string StartDate { get; set; } = "";

        [StringLength(10)]
        [Unicode(false)]
        public string EndDate { get; set; } = "";

        [Column(TypeName = "datetime")]
        public DateTime RegDate { get; set; }

    }
}
