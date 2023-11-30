using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 시리얼쿠폰-유저 릴레이션
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class serial_coupon_user
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// user idx
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int serial_coupon_id { get; set; }

    /// <summary>
    /// user idx
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    /// <summary>
    /// user idx
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int start_datetime { get; set; }

    /// <summary>
    /// user idx
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int end_datetime { get; set; }
}
