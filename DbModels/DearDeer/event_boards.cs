using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 이벤트 게시판
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class event_boards
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 이벤트 명
    /// </summary>
    [StringLength(255)]
    public string subject { get; set; } = null!;

    /// <summary>
    /// 이벤트 시작일
    /// </summary>
    [StringLength(20)]
    public string? start_date { get; set; }

    /// <summary>
    /// 이벤트 종료일
    /// </summary>
    [StringLength(20)]
    public string? end_date { get; set; }

    /// <summary>
    /// 이벤트 간단 설명
    /// </summary>
    [StringLength(255)]
    public string? summary { get; set; }

    /// <summary>
    /// 이벤트 설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// comment 작성 버튼명
    /// </summary>
    [StringLength(30)]
    public string? btn_name { get; set; }

    /// <summary>
    /// 모바일 상품상세 설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? moboil_contents { get; set; }

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
    /// 리스트 베너
    /// </summary>
    [StringLength(255)]
    public string? list_banner { get; set; }

    /// <summary>
    /// 디테일 페이지 베너
    /// </summary>
    [StringLength(255)]
    public string? detail_banner { get; set; }

    /// <summary>
    /// NO, START, END, ANNOUNCE
    /// </summary>
    [StringLength(10)]
    public string? state { get; set; }

    /// <summary>
    /// 노출 순서
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [StringLength(1)]
    public string use_comment { get; set; } = null!;

    /// <summary>
    /// 옵션사용
    /// </summary>
    [StringLength(1)]
    public string use_option { get; set; } = null!;

    /// <summary>
    /// 링크사용
    /// </summary>
    [StringLength(1)]
    public string use_link { get; set; } = null!;

    /// <summary>
    /// 링크
    /// </summary>
    [StringLength(255)]
    public string? link { get; set; }

    /// <summary>
    /// 쿠폰사용
    /// </summary>
    [StringLength(1)]
    public string use_coupon { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
