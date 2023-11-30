using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 배너 이미지
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class banner_images
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// banners.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint banner_id { get; set; }

    /// <summary>
    /// url
    /// </summary>
    [StringLength(255)]
    public string? path { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
