using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 쿠폰발급내역
/// </summary>
[Index("coupon_id", Name = "coupon_id")]
[Index("coupon_id", "user_id", "is_used", Name = "coupon_id_is_used_user_id")]
[Index("order_no", Name = "order_no")]
[Index("user_id", Name = "user_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class coupon_issue
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// coupons.id
    /// </summary>
    [StringLength(50)]
    public string? issue_no { get; set; }

    /// <summary>
    /// coupons.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int coupon_id { get; set; }

    /// <summary>
    /// users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    /// <summary>
    /// 사용하였뉘
    /// </summary>
    [StringLength(1)]
    public string is_used { get; set; } = null!;

    /// <summary>
    /// order.order_no
    /// </summary>
    [StringLength(50)]
    public string? order_no { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
