using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 쿠폰정보
/// </summary>
public partial class SMARTAD_COUPON_MST
{
    [Key]
    public int SMARTAD_COUPON_MST_SEQ { get; set; }

    public int? AD_SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? COUPON_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? COUPON_CD { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? DISCOUNT_TYPE { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? DISCOUNT_PRICE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? END_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }

    public int ISSUE_CNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PROMOTION_TYPE { get; set; }
}
