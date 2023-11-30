using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 초안비용산출
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class cost_manage
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 타입
    /// </summary>
    [StringLength(20)]
    public string? type { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    [StringLength(20)]
    public string? desc { get; set; }

    /// <summary>
    /// 비용
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int cost { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
