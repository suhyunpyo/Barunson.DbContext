using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 일별 결제 로그
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class daily_account_log
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 날짜
    /// </summary>
    public DateOnly date { get; set; }

    /// <summary>
    /// 주문타입
    /// </summary>
    [StringLength(20)]
    public string order_base { get; set; } = null!;

    /// <summary>
    /// 상태
    /// </summary>
    [StringLength(1)]
    public string order_state { get; set; } = null!;

    /// <summary>
    /// 합계
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int amount { get; set; }

    /// <summary>
    /// 주문건수
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int count { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
