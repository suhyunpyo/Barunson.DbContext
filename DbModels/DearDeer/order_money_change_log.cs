using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 금액변동 로그
/// </summary>
[Index("order_id", Name = "order_id")]
[Index("order_no", Name = "order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_money_change_log
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
    /// orders.order_no
    /// </summary>
    [StringLength(30)]
    public string order_no { get; set; } = null!;

    /// <summary>
    /// 환불은행
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? before { get; set; }

    /// <summary>
    /// 환불계좌
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? after { get; set; }

    /// <summary>
    /// 남긴사람
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? owner_id { get; set; }

    /// <summary>
    /// 변경 사유메모
    /// </summary>
    [Column(TypeName = "text")]
    public string? change_memo { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
