using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class best_sample
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// PC 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? pc_contents { get; set; }

    /// <summary>
    /// MO 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? mo_contents { get; set; }

    /// <summary>
    /// pc 업로드 이미지
    /// </summary>
    [StringLength(255)]
    public string? pc_banner_image { get; set; }

    /// <summary>
    /// mo 업로드 이미지
    /// </summary>
    [StringLength(255)]
    public string? mo_banner_image { get; set; }

    /// <summary>
    /// 작성자
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int owner_id { get; set; }

    /// <summary>
    /// 수정자
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int updater_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    /// <summary>
    /// 샘플명
    /// </summary>
    [StringLength(200)]
    public string? samplename { get; set; }
}
