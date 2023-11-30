using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 배너관리
/// </summary>
[Index("code", Name = "idx_code")]
[MySqlCollation("utf8_unicode_ci")]
public partial class banners
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 베너명
    /// </summary>
    [StringLength(255)]
    public string? name { get; set; }

    /// <summary>
    /// 노출코드
    /// </summary>
    [StringLength(50)]
    public string? code { get; set; }

    /// <summary>
    /// 라벨
    /// </summary>
    [StringLength(100)]
    public string? banner_label { get; set; }

    /// <summary>
    /// 카테고리
    /// </summary>
    [StringLength(100)]
    public string? category { get; set; }

    /// <summary>
    /// 슬라이드방향
    /// </summary>
    [StringLength(20)]
    public string type { get; set; } = null!;

    /// <summary>
    /// 슬라이드 시간
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int interval { get; set; }

    /// <summary>
    /// 작성자
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int owner_id { get; set; }

    /// <summary>
    /// 업데이트한사람
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int updater_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
