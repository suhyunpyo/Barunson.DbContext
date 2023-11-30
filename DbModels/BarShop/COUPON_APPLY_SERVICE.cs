using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 적용상품범위
/// </summary>
public partial class COUPON_APPLY_SERVICE
{
    /// <summary>
    /// SEQ
    /// </summary>
    [Key]
    public int COUPON_APPLY_SERVICE_SEQ { get; set; }

    /// <summary>
    /// COUPON_MST.COUPON_MST_SEQ
    /// </summary>
    public int COUPON_MST_SEQ { get; set; }

    /// <summary>
    /// 그룹코드(COMMON_CODE.CLSS_CODE)
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string CLSS_CODE { get; set; } = null!;

    /// <summary>
    /// 상세코드(COMMON_CODE.CMMN_CODE)
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string CMMN_CODE { get; set; } = null!;

    [ForeignKey("COUPON_MST_SEQ")]
    [InverseProperty("COUPON_APPLY_SERVICE")]
    public virtual COUPON_MST COUPON_MST_SEQNavigation { get; set; } = null!;
}
