using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 기본사이트맵 정보
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class sitemap
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// URL을 넣어주세요.
    /// </summary>
    [StringLength(255)]
    public string loc { get; set; } = null!;

    /// <summary>
    /// always, hourly, daily, weekly, monthly, yearly, never
    /// </summary>
    [StringLength(8)]
    public string changefreq { get; set; } = null!;

    /// <summary>
    /// 10 ~ 1
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int priority { get; set; }

    /// <summary>
    /// A: Auto, M: Manual
    /// </summary>
    [StringLength(1)]
    public string add_type { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
