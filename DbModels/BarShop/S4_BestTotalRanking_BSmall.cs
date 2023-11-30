using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 바른손몰 랭킹
/// </summary>
[PrimaryKey("Gubun_date", "Gubun", "SubGubun", "RankNo")]
public partial class S4_BestTotalRanking_BSmall
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Gubun_date { get; set; } = null!;

    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string Gubun { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string SubGubun { get; set; } = null!;

    [Key]
    public short RankNo { get; set; }

    public int Card_Seq { get; set; }

    public int Cnt { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? RankChangeGubun { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? RankChangeNo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime RegDate { get; set; }
}
