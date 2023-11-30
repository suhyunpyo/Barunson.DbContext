using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 시리얼쿠폰 발급
/// </summary>
public partial class serial_coupon_issue
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// coupons.id
    /// </summary>
    [StringLength(50)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? issue_no { get; set; }

    /// <summary>
    /// serial_coupons.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int serial_coupon_id { get; set; }

    /// <summary>
    /// users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    /// <summary>
    /// 사용하였뉘
    /// </summary>
    [StringLength(1)]
    [MySqlCollation("utf8_unicode_ci")]
    public string is_used { get; set; } = null!;

    /// <summary>
    /// order.order_no
    /// </summary>
    [StringLength(50)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? order_no { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
