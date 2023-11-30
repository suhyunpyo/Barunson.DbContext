using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 운영관리
/// </summary>
[Index("code", Name = "idx_code")]
[MySqlCollation("utf8_unicode_ci")]
public partial class site_policy
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 타입
    /// </summary>
    [StringLength(10)]
    public string? type { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    [StringLength(20)]
    public string? name { get; set; }

    /// <summary>
    /// 코드
    /// </summary>
    [StringLength(20)]
    public string? code { get; set; }

    /// <summary>
    /// T:사용함, F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_policy { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? contents { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
