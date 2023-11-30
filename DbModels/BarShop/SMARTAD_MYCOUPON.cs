using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 받은쿠폰
/// </summary>
public partial class SMARTAD_MYCOUPON
{
    [Key]
    public int MYCOUPON_SEQ { get; set; }

    public int SMARTAD_COUPON_MST_SEQ { get; set; }

    [StringLength(50)]
    public string? COUPON_CD { get; set; }

    public int AD_SEQ { get; set; }

    [StringLength(50)]
    public string? UID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
