using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 쿠폰 적용 내역
/// </summary>
[Index("COUPON_ISSUE_SEQ", Name = "NCI_COUPON_ISSUE_SEQ")]
[Index("ORDER_SEQ", Name = "NCI_ORDER_SEQ")]
[Index("REG_DATE", Name = "NCI_REG_DATE")]
public partial class CUSTOM_ORDER_COUPON
{
    [Key]
    public int ORDER_COUPON_SEQ { get; set; }

    public int COUPON_ISSUE_SEQ { get; set; }

    public int ORDER_SEQ { get; set; }

    public int COUPON_AMT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
