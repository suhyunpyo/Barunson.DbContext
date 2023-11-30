using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 주문_임시
/// </summary>
public partial class TB_Temp_Order
{
    /// <summary>
    /// 주문코드
    /// </summary>
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string Order_Code { get; set; } = null!;

    /// <summary>
    /// 쿠폰발급아이디
    /// </summary>
    public int? Coupon_Publish_ID { get; set; }

    /// <summary>
    /// 쿠폰가격
    /// </summary>
    public int? Coupon_Price { get; set; }

    public string? PaymentData { get; set; }
}
