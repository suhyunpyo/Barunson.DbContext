using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 쿠폰 발급 사이트
/// </summary>
public partial class COUPON_APPLY_SITE
{
    /// <summary>
    /// SEQ
    /// </summary>
    [Key]
    public int COUPON_APPLY_SITE_SEQ { get; set; }

    /// <summary>
    /// COUPON_MST.COUPON_MST_SEQ
    /// </summary>
    public int COUPON_MST_SEQ { get; set; }

    /// <summary>
    /// COMPANY_SEQ
    /// </summary>
    public int COMPANY_SEQ { get; set; }

    [ForeignKey("COUPON_MST_SEQ")]
    [InverseProperty("COUPON_APPLY_SITE")]
    public virtual COUPON_MST COUPON_MST_SEQNavigation { get; set; } = null!;
}
