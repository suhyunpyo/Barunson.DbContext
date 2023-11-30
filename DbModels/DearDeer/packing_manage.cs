using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 스마트 패킹(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class packing_manage
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 패킹바구니 번호
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int packing_no { get; set; }

    /// <summary>
    /// 바구니 상태
    /// </summary>
    [StringLength(1)]
    public string is_empty { get; set; } = null!;

    [StringLength(1)]
    public string is_alive { get; set; } = null!;

    /// <summary>
    /// 주문건 
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? order_id { get; set; }

    /// <summary>
    /// 바구니 상태
    /// </summary>
    [StringLength(30)]
    public string? order_no { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
