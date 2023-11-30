using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class main_display
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 디스플레이 타이틀
    /// </summary>
    [StringLength(255)]
    public string? subject { get; set; }

    /// <summary>
    /// 배경색
    /// </summary>
    [StringLength(10)]
    public string? color_primary { get; set; }

    /// <summary>
    /// 색상2
    /// </summary>
    [StringLength(10)]
    public string? color_secondary { get; set; }

    /// <summary>
    /// 색상3
    /// </summary>
    [StringLength(10)]
    public string? color_tertiary { get; set; }

    /// <summary>
    /// 디스플레이 타이틀 대체 이미지
    /// </summary>
    [StringLength(255)]
    public string? display_image { get; set; }

    /// <summary>
    /// F: 사용함, T: 사용안함
    /// </summary>
    [StringLength(1)]
    public string? is_display { get; set; }

    /// <summary>
    /// 꾸미기 HTML
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 정렬의 절렬
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
