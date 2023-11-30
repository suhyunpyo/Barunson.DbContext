using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 인쇄규격
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class product_format
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// product.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int product_id { get; set; }

    /// <summary>
    /// 구조 (F001: 2단 가로, F002: 2단 세로, F003: 3단 가로, F004: 3단 세로, F005: 단장 양면, F006: 단장 단면 2장 구성, F007: 단장 양면 2장 구성)
    /// </summary>
    [StringLength(5)]
    public string? format_type { get; set; }

    /// <summary>
    /// 가로 길이 mm
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? format_x { get; set; }

    /// <summary>
    /// 세로 길이 mm
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? format_y { get; set; }

    /// <summary>
    /// 종이
    /// </summary>
    [StringLength(50)]
    public string? format_paper { get; set; }

    /// <summary>
    /// 가공
    /// </summary>
    [StringLength(50)]
    public string? format_manufacture { get; set; }

    /// <summary>
    /// 봉투
    /// </summary>
    [StringLength(50)]
    public string? format_envelope { get; set; }

    /// <summary>
    /// 별첨
    /// </summary>
    [StringLength(50)]
    public string? format_attache { get; set; }

    /// <summary>
    /// 기타폰트
    /// </summary>
    [StringLength(50)]
    public string? format_font { get; set; }

    /// <summary>
    /// 생산처
    /// </summary>
    [StringLength(50)]
    public string? format_producing { get; set; }

    [StringLength(10)]
    public string? color_type { get; set; }

    [StringLength(20)]
    public string? color { get; set; }

    [StringLength(20)]
    public string? point { get; set; }

    [Column(TypeName = "int(11)")]
    public int? front_pos { get; set; }

    [Column(TypeName = "int(11)")]
    public int? back_pos { get; set; }

    [Column(TypeName = "int(11)")]
    public int? master_width { get; set; }

    [Column(TypeName = "int(11)")]
    public int? master_height { get; set; }

    [StringLength(10)]
    public string? print_type { get; set; }

    [StringLength(1)]
    public string? is_map_background { get; set; }

    [StringLength(20)]
    public string? map_background { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "double(8,2)")]
    public double? format_width { get; set; }

    [Column(TypeName = "double(8,2)")]
    public double? format_height { get; set; }
}
