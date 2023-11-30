using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 토스 재고(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class toss_stock
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 코드
    /// </summary>
    [StringLength(20)]
    public string? code { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    [StringLength(100)]
    public string? desc { get; set; }

    /// <summary>
    /// 재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int stock { get; set; }

    /// <summary>
    /// 안전재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int safety_stock { get; set; }

    /// <summary>
    /// 금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int money { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
