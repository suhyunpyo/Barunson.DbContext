using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 영상주문관리(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class movie_order
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? template_id { get; set; }

    /// <summary>
    /// 상품 번호
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? product_id { get; set; }

    /// <summary>
    /// 유저아이디
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// order.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? order_id { get; set; }

    /// <summary>
    /// order_item.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? order_item_id { get; set; }

    /// <summary>
    /// order.order_no
    /// </summary>
    [StringLength(30)]
    public string? order_no { get; set; }

    /// <summary>
    /// order_item.order_item_no
    /// </summary>
    [StringLength(30)]
    public string? order_item_no { get; set; }

    /// <summary>
    /// 신랑이름
    /// </summary>
    [StringLength(30)]
    public string? groom_name { get; set; }

    /// <summary>
    /// 신랑영문
    /// </summary>
    [StringLength(100)]
    public string? groom_name_en { get; set; }

    /// <summary>
    /// 신랑 몇째
    /// </summary>
    [StringLength(10)]
    public string? groom_rank { get; set; }

    /// <summary>
    /// 신랑 전화
    /// </summary>
    [StringLength(20)]
    public string? groom_phone { get; set; }

    /// <summary>
    /// 신랑 부
    /// </summary>
    [StringLength(30)]
    public string? groom_father { get; set; }

    /// <summary>
    /// 신랑 모
    /// </summary>
    [StringLength(30)]
    public string? groom_mother { get; set; }

    /// <summary>
    /// 신부이름
    /// </summary>
    [StringLength(30)]
    public string? bride_name { get; set; }

    /// <summary>
    /// 신부이름 영문
    /// </summary>
    [StringLength(100)]
    public string? bride_name_en { get; set; }

    /// <summary>
    /// 신부 몇째
    /// </summary>
    [StringLength(10)]
    public string? bride_rank { get; set; }

    /// <summary>
    /// 신부 전화
    /// </summary>
    [StringLength(20)]
    public string? bride_phone { get; set; }

    /// <summary>
    /// 신부 부
    /// </summary>
    [StringLength(30)]
    public string? bride_father { get; set; }

    /// <summary>
    /// 신부 모
    /// </summary>
    [StringLength(30)]
    public string? bride_mother { get; set; }

    /// <summary>
    /// 예식일
    /// </summary>
    [StringLength(20)]
    public string? wedd_date { get; set; }

    /// <summary>
    /// 예식 시
    /// </summary>
    [StringLength(10)]
    public string? wedd_hour { get; set; }

    /// <summary>
    /// 예식 분
    /// </summary>
    [StringLength(2)]
    public string? wedd_minute { get; set; }

    /// <summary>
    /// 예식장소
    /// </summary>
    [StringLength(100)]
    public string? wedd_name { get; set; }

    /// <summary>
    /// 예식홀
    /// </summary>
    [StringLength(100)]
    public string? wedd_place { get; set; }

    [StringLength(255)]
    public string? vimeo { get; set; }

    /// <summary>
    /// zip 파일 링크
    /// </summary>
    [StringLength(255)]
    public string? link { get; set; }

    /// <summary>
    /// 기타내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? etc { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
