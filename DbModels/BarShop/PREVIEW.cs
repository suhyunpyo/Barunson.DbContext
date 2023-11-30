using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PREVIEW
{
    [Key]
    public int preview_seq { get; set; }

    public int? card_seq { get; set; }

    public int order_Seq { get; set; }

    /// <summary>
    /// C:카드,E:봉투,M:미니청첩장
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? preview_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CE { get; set; }

    public int? sid { get; set; }

    public byte? tbl_seq { get; set; }

    public byte? corel_pnum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? imgFolder { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? imgName { get; set; }

    public short? imgWidth { get; set; }

    public short? imgHeight { get; set; }

    public float? imgRatio { get; set; }

    public byte? step { get; set; }

    public byte checkCnt { get; set; }

    public byte Pstatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string subject { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime Rdate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Mdate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? confirm_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? print_date { get; set; }

    [StringLength(1024)]
    [Unicode(false)]
    public string? content { get; set; }
}
