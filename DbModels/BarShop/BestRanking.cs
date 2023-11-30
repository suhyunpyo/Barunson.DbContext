using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class BestRanking
{
    [StringLength(1)]
    [Unicode(false)]
    public string sales_Gubun { get; set; } = null!;

    public short? Rank { get; set; }

    public int? Card_Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Card_Code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Card_img_ms { get; set; }

    public short? Cnt { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Ranking { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    /// <summary>
    /// 1:주간, 2:월간, 3:샘플구매, 4:찜카드, 5:이용후기
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? Gubun { get; set; }
}
