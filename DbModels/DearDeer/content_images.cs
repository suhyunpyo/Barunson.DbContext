using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 상품상세 에디터에서 업로드된 이미지
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class content_images
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// table.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint target_id { get; set; }

    /// <summary>
    /// 작성자
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// table 명
    /// </summary>
    [StringLength(20)]
    public string? target { get; set; }

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
