using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 인쇄규격관리(사용안함)
/// </summary>
[Index("item_code", Name = "item_typeset_item_code_unique", IsUnique = true)]
[MySqlCollation("utf8_unicode_ci")]
public partial class item_typeset
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 아이템 코드
    /// </summary>
    [StringLength(20)]
    public string item_code { get; set; } = null!;

    /// <summary>
    /// 표지 방향
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? pos_cover { get; set; }

    /// <summary>
    /// 내지 방향
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? pos_page { get; set; }

    /// <summary>
    /// 마스터 가로 길이
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? master_width { get; set; }

    /// <summary>
    /// 마스터 세로 길이
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? master_height { get; set; }

    /// <summary>
    /// 마스터 인쇄 제품 배경 이미지 리스트형태
    /// </summary>
    [StringLength(255)]
    public string? master_background_image { get; set; }

    /// <summary>
    /// 배경이미지 T: 사용함, F: 사용안함
    /// </summary>
    [StringLength(1)]
    public string use_background_image { get; set; } = null!;

    /// <summary>
    /// 프린트 타입 : digital, master
    /// </summary>
    [StringLength(10)]
    public string? type_print { get; set; }

    [StringLength(10)]
    public string? direction_print { get; set; }

    /// <summary>
    /// 지도 포인트 색
    /// </summary>
    [StringLength(20)]
    public string? map_point { get; set; }

    /// <summary>
    /// 지도 선색
    /// </summary>
    [StringLength(20)]
    public string? map_color { get; set; }

    /// <summary>
    /// 지도 인쇄타입
    /// </summary>
    [StringLength(10)]
    public string? map_color_type { get; set; }

    /// <summary>
    /// 배경색 지정
    /// </summary>
    [StringLength(20)]
    public string? map_background { get; set; }

    /// <summary>
    /// 배경색 변경
    /// </summary>
    [StringLength(1)]
    public string? is_map_background { get; set; }

    /// <summary>
    /// 식권넘버링 (T:함/F:안함)
    /// </summary>
    [StringLength(1)]
    public string is_numbering { get; set; } = null!;

    /// <summary>
    /// 생산처
    /// </summary>
    [StringLength(50)]
    public string? format_producing { get; set; }

    /// <summary>
    /// 별첨
    /// </summary>
    [StringLength(50)]
    public string? format_attache { get; set; }

    /// <summary>
    /// 봉투
    /// </summary>
    [StringLength(50)]
    public string? format_envelope { get; set; }

    /// <summary>
    /// 후가공
    /// </summary>
    [StringLength(50)]
    public string? format_manufacture { get; set; }

    /// <summary>
    /// 종이
    /// </summary>
    [StringLength(50)]
    public string? format_paper { get; set; }

    /// <summary>
    /// 세로 길이 mm
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? format_y { get; set; }

    /// <summary>
    /// 가로 길이 mm
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? format_x { get; set; }

    /// <summary>
    /// 청첩장 모양 구조
    /// </summary>
    [StringLength(20)]
    public string? format_type { get; set; }

    /// <summary>
    /// T: 완제품, F: 인쇄제품
    /// </summary>
    [StringLength(1)]
    public string is_printed { get; set; } = null!;

    /// <summary>
    /// 재고사용여부
    /// </summary>
    [StringLength(1)]
    public string use_stock { get; set; } = null!;

    /// <summary>
    /// 재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int stock { get; set; }

    /// <summary>
    /// 안전재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int safety_stock { get; set; }

    /// <summary>
    /// 샘플재고사용여부
    /// </summary>
    [StringLength(1)]
    public string use_sample_stock { get; set; } = null!;

    /// <summary>
    /// 샘플재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sample_stock { get; set; }

    /// <summary>
    /// 샘플안전재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sample_safety_stock { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
