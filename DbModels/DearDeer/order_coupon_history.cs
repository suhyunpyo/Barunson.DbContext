using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문 쿠폰 사용내역
/// </summary>
[Index("coupon_id", Name = "coupon_id")]
[Index("order_id", Name = "order_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_coupon_history
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// orders.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    /// <summary>
    /// coupons.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int coupon_id { get; set; }

    /// <summary>
    /// 쿠폰 타입 (D:기본 / P:제휴사)
    /// </summary>
    [StringLength(1)]
    public string? coupon_type { get; set; }

    /// <summary>
    /// 할인타입
    /// </summary>
    [StringLength(1)]
    public string? benefit_type { get; set; }

    /// <summary>
    /// 할인금액 or 할인율
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int benefit_price { get; set; }

    /// <summary>
    /// 할인적용금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int discount_price { get; set; }

    /// <summary>
    /// partner_shop.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int partner_shop_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
