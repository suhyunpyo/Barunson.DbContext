using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class BestRankingB2B
{
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

    [StringLength(1)]
    [Unicode(false)]
    public string? Gubun { get; set; }
}
