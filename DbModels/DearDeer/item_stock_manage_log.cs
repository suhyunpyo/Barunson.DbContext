using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 인쇄규격 재고 로그(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class item_stock_manage_log
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// item_stock_manage.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int item_stock_manage_id { get; set; }

    /// <summary>
    /// 이전수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int before { get; set; }

    /// <summary>
    /// 이후수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int after { get; set; }

    /// <summary>
    /// I:기본, S:샘플
    /// </summary>
    [StringLength(1)]
    public string stock_base { get; set; } = null!;

    /// <summary>
    /// P:패킹, A:충전, M: 수동빼기
    /// </summary>
    [StringLength(1)]
    public string log_type { get; set; } = null!;

    /// <summary>
    /// 업데이트 메모
    /// </summary>
    [StringLength(255)]
    public string? memo { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
