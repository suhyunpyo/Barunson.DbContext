using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 바른손-디얼디어 코드매칭
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class code_map_barunson
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 디얼디어 상품 코드
    /// </summary>
    [StringLength(20)]
    public string item_code { get; set; } = null!;

    /// <summary>
    /// 바른손 상품 시퀀스
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? barunson_card_seq { get; set; }

    /// <summary>
    /// 바른손 상품 코드
    /// </summary>
    [StringLength(20)]
    public string? barunson_card_code { get; set; }

    /// <summary>
    /// 제품타입- 0: 청첩장아님, 1: 청첩장, 2: 감사장, 6: 디지털, 7: 박광압
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte? print_type { get; set; }

    /// <summary>
    /// 인쇄제품: T, 완제품: F
    /// </summary>
    [StringLength(1)]
    public string? is_printed { get; set; }

    /// <summary>
    /// C:기본(카드), I:내지, P:별첨
    /// </summary>
    [StringLength(1)]
    public string card_type { get; set; } = null!;

    /// <summary>
    /// T:인쇄함, F:인쇄안함
    /// </summary>
    [StringLength(1)]
    public string is_print { get; set; } = null!;

    /// <summary>
    /// T:양면인쇄, F:단면인쇄
    /// </summary>
    [StringLength(1)]
    public string is_both_side_print { get; set; } = null!;

    /// <summary>
    /// 생상처
    /// </summary>
    [StringLength(30)]
    public string? format_producing { get; set; }

    /// <summary>
    /// 후가공
    /// </summary>
    [StringLength(30)]
    public string? format_manufacture { get; set; }

    /// <summary>
    /// 제작일
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? schedule_day { get; set; }

    /// <summary>
    /// 기본이미지 초안에서 사용예정이지
    /// </summary>
    [StringLength(100)]
    public string? base_image { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
