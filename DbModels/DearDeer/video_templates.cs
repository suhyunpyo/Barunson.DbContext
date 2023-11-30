using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 영상템플릿(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class video_templates
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 상품명
    /// </summary>
    [StringLength(255)]
    public string name { get; set; } = null!;

    /// <summary>
    /// 상품고유코드
    /// </summary>
    [StringLength(20)]
    public string? code { get; set; }

    /// <summary>
    /// 상품 번호
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? owner_id { get; set; }

    /// <summary>
    /// 상품 번호
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? updater_id { get; set; }

    /// <summary>
    /// 상품 속성 라벨
    /// </summary>
    [StringLength(100)]
    public string? video_label { get; set; }

    /// <summary>
    /// 상품 간단 설명
    /// </summary>
    [StringLength(255)]
    public string? summary { get; set; }

    /// <summary>
    /// 상품상세 설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 모바일 상품상세 설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? moboil_contents { get; set; }

    /// <summary>
    /// 대표이미지
    /// </summary>
    [StringLength(255)]
    public string? represent_image { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
