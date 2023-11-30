using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 모바일청첩장 추가입력값
/// </summary>
[Index("target", "add_type", "target_id", Name = "idx_target")]
[MySqlCollation("utf8_unicode_ci")]
public partial class mobile_card_addition
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(30)]
    public string? target { get; set; }

    [Column(TypeName = "int(11)")]
    public int? target_id { get; set; }

    /// <summary>
    /// 입력값 이름
    /// </summary>
    [StringLength(100)]
    public string? add_name { get; set; }

    /// <summary>
    /// 입력값 
    /// </summary>
    [StringLength(2000)]
    public string? add_value { get; set; }

    /// <summary>
    /// 입력값 타입 (image, text, slide)
    /// </summary>
    [StringLength(10)]
    public string? add_type { get; set; }

    /// <summary>
    /// 입력값 색상
    /// </summary>
    [StringLength(7)]
    public string? add_color { get; set; }

    [StringLength(7)]
    public string? add_back { get; set; }

    /// <summary>
    /// 입력값 크기
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? add_size { get; set; }

    /// <summary>
    /// 입력값 굵기
    /// </summary>
    [StringLength(10)]
    public string? add_weight { get; set; }

    /// <summary>
    /// 입력값 폰트종류
    /// </summary>
    [StringLength(50)]
    public string? add_family { get; set; }

    [StringLength(2)]
    public string? add_position { get; set; }

    [StringLength(3)]
    public string? add_rotate { get; set; }

    /// <summary>
    /// 시작점 x %
    /// </summary>
    public float add_x { get; set; }

    /// <summary>
    /// 시작점 y %
    /// </summary>
    public float add_y { get; set; }

    /// <summary>
    /// 시작점 가로크기 %
    /// </summary>
    public float add_w { get; set; }

    /// <summary>
    /// 시작점 세로크기 %
    /// </summary>
    public float add_h { get; set; }

    /// <summary>
    /// 중앙 위치 x = (시작점 x + ( 시작점 가로크기/ 2 ) ) ...
    /// </summary>
    public float add_cx { get; set; }

    /// <summary>
    /// 중앙 위치 y = (시작점 y + ( 시작점 세로크기/ 2 ) ) ...
    /// </summary>
    public float add_cy { get; set; }

    /// <summary>
    /// 폰트크기 %
    /// </summary>
    public float add_f { get; set; }

    /// <summary>
    /// 부모
    /// </summary>
    [StringLength(50)]
    public string add_p { get; set; } = null!;

    [StringLength(1)]
    public string is_full_width { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
