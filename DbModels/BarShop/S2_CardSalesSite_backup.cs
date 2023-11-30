using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_CardSalesSite_backup
{
    public int card_seq { get; set; }

    public int Company_Seq { get; set; }

    public int? CardDiscount_Seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsDisplay { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsJumun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsNew { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsBest { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsExtra { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsJehyu { get; set; }

    public short? Ranking { get; set; }

    public short? Ranking_w { get; set; }

    public short? Ranking_m { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? input_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSale { get; set; }

    public short? SampRankNo { get; set; }

    public short? PostRankNo { get; set; }

    public short? ZzimRankNo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AppSample { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNotCoupon { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsExtra2 { get; set; }

    public int? isRecommend { get; set; }

    public int? isSSPre { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? isSummary { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? isBgcolor { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isDigitalCard { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Display_Date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsInProduct { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? MovieURL { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? DisplayLabel { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Tip { get; set; }

    public int? sealingsticker_seq { get; set; }

    public int? sealingsticker_groupseq { get; set; }

    public int? ribbon_seq { get; set; }

    public int? ribbon_groupseq { get; set; }

    public int? papercover_seq { get; set; }

    public int? papercover_groupseq { get; set; }

    public int? Flower_seq { get; set; }

    public int? Flower_GroupSeq { get; set; }

    public int? pocket_seq { get; set; }

    public int? pocket_groupseq { get; set; }
}
