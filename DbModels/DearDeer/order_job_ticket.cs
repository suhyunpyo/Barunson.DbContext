using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문 업무관리
/// </summary>
[Index("order_id", Name = "order_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_job_ticket
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 작성자 id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? manager { get; set; }

    /// <summary>
    /// orders.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? order_id { get; set; }

    /// <summary>
    /// orders.order_no
    /// </summary>
    [StringLength(30)]
    public string? order_no { get; set; }

    /// <summary>
    /// 작업내역
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 확인 유무
    /// </summary>
    [Column("checked", TypeName = "int(11)")]
    public int? _checked { get; set; }

    /// <summary>
    /// 확인한 사람
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? checked_manager { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
