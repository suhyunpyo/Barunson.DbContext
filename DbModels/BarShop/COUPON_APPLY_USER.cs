using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 회원제외추가리스트
/// </summary>
public partial class COUPON_APPLY_USER
{
    /// <summary>
    /// SEQ
    /// </summary>
    [Key]
    public int COUPON_APPLY_USER_SEQ { get; set; }

    /// <summary>
    /// COUPON_MST.COUPON_MST_SEQ
    /// </summary>
    public int COUPON_MST_SEQ { get; set; }

    /// <summary>
    /// UID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    /// <summary>
    /// 회원허구분(N:제외,Y:등록)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string USER_ALLOW_YN { get; set; } = null!;

    [ForeignKey("COUPON_MST_SEQ")]
    [InverseProperty("COUPON_APPLY_USER")]
    public virtual COUPON_MST COUPON_MST_SEQNavigation { get; set; } = null!;
}
