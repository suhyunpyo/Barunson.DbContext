using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 부가상품
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class invitation_card_addition
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 코드
    /// </summary>
    [StringLength(255)]
    public string? add_code { get; set; }

    [StringLength(50)]
    public string? add_manage_name { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    [StringLength(255)]
    public string? add_name { get; set; }

    /// <summary>
    /// 타입 : T:식권, S:스티커
    /// </summary>
    [StringLength(3)]
    public string add_type { get; set; } = null!;

    /// <summary>
    /// 씰링(0:일반, 1:씰링)
    /// </summary>
    [StringLength(1)]
    public string? add_type_sub { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    [StringLength(255)]
    public string? add_desc { get; set; }

    [Column(TypeName = "int(11)")]
    public int? add_qty { get; set; }

    /// <summary>
    /// 추가금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? add_price { get; set; }

    [StringLength(255)]
    public string? brand { get; set; }

    [StringLength(255)]
    public string? format_x { get; set; }

    [StringLength(255)]
    public string? format_y { get; set; }

    [StringLength(255)]
    public string? paper { get; set; }

    [StringLength(255)]
    public string? manufacture { get; set; }

    [StringLength(255)]
    public string? producing { get; set; }

    /// <summary>
    /// 판나누기 금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int divide_print_price { get; set; }

    /// <summary>
    /// 판나누기 설정 T:사용함 / F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_divide_print { get; set; } = null!;

    /// <summary>
    /// 시작번호 사용 설정 T:사용함 / F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_start_no { get; set; } = null!;

    /// <summary>
    /// 수량나누기 설정 T:사용함 / F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_divide_qty { get; set; } = null!;

    /// <summary>
    /// qty 셀렉트박스
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int divide_qty { get; set; }

    /// <summary>
    /// 추가입력값 사용여부 설정 T:사용함 / F:사용안함
    /// </summary>
    [StringLength(1)]
    public string use_addition_field { get; set; } = null!;

    /// <summary>
    /// 추가 입력값 포맷 설정
    /// </summary>
    [Column(TypeName = "text")]
    public string? addition_field { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    /// <summary>
    /// 청첩장 구매 페이지 노출 여부
    /// </summary>
    [StringLength(1)]
    public string view_yn { get; set; } = null!;
}
