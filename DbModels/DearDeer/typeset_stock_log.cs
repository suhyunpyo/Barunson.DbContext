using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// (사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class typeset_stock_log
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// item_typeset.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int item_typeset_id { get; set; }

    /// <summary>
    /// item_typeset.item_code
    /// </summary>
    [StringLength(20)]
    public string? code { get; set; }

    /// <summary>
    /// 주문번호
    /// </summary>
    [StringLength(30)]
    public string? order_no { get; set; }

    /// <summary>
    /// M:마이너스, P:플러스
    /// </summary>
    [StringLength(1)]
    public string? type { get; set; }

    /// <summary>
    /// 수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int cnt { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    [StringLength(255)]
    public string? desc { get; set; }

    /// <summary>
    /// 이전수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int before { get; set; }

    /// <summary>
    /// 변경된수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int after { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
