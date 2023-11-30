using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 일부상품적용제외리스트
/// </summary>
public partial class COUPON_APPLY_CARD
{
    /// <summary>
    /// SEQ
    /// </summary>
    [Key]
    public int COUPON_APPLY_CARD_SEQ { get; set; }

    /// <summary>
    /// COUPON_MST.COUPON_MST_SEQ
    /// </summary>
    public int COUPON_MST_SEQ { get; set; }

    /// <summary>
    /// 카드코드(S2_CARD.CARD_SEQ)
    /// </summary>
    public int CARD_SEQ { get; set; }

    /// <summary>
    /// 상품허용구분(N:제외,Y:등록)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string CARD_ALLOW_YN { get; set; } = null!;

    [ForeignKey("COUPON_MST_SEQ")]
    [InverseProperty("COUPON_APPLY_CARD")]
    public virtual COUPON_MST COUPON_MST_SEQNavigation { get; set; } = null!;
}
