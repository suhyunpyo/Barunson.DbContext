using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 쿠폰관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class coupons
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 쿠폰명
    /// </summary>
    [StringLength(100)]
    public string? coupon_name { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    [StringLength(255)]
    public string? coupon_desc { get; set; }

    /// <summary>
    /// 쿠폰 타입 (D:기본 / P:제휴사)
    /// </summary>
    [StringLength(1)]
    public string coupon_type { get; set; } = null!;

    /// <summary>
    /// 혜택구분
    /// </summary>
    [StringLength(1)]
    public string benefit_type { get; set; } = null!;

    /// <summary>
    /// 혜택금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int benefit_price { get; set; }

    /// <summary>
    /// 원단위 절삭
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int benefit_round_unit { get; set; }

    /// <summary>
    /// 최대할인금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int benefit_max_price { get; set; }

    /// <summary>
    /// 지역배송비
    /// </summary>
    [StringLength(1)]
    public string include_region_shipping_fee { get; set; } = null!;

    /// <summary>
    /// 해외배송비
    /// </summary>
    [StringLength(1)]
    public string include_foreign_delivery { get; set; } = null!;

    /// <summary>
    /// 중복할인
    /// </summary>
    [StringLength(1)]
    public string is_duplicate { get; set; } = null!;

    /// <summary>
    /// 최대발급수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int issue_limit { get; set; }

    /// <summary>
    /// 발급구분
    /// </summary>
    [StringLength(2)]
    public string issue_type { get; set; } = null!;

    /// <summary>
    /// 추천인대상발급
    /// </summary>
    [StringLength(1)]
    public string issue_recommender { get; set; } = null!;

    /// <summary>
    /// 가입자대상발급
    /// </summary>
    [StringLength(1)]
    public string issue_join_user { get; set; } = null!;

    /// <summary>
    /// 제공동의 발급
    /// </summary>
    [StringLength(1)]
    public string issue_join_type { get; set; } = null!;

    /// <summary>
    /// 발급단위
    /// </summary>
    [StringLength(1)]
    public string? issued_level_type { get; set; }

    /// <summary>
    /// 주문경로
    /// </summary>
    [StringLength(2)]
    public string? issue_order_path_type_serial { get; set; }

    /// <summary>
    /// 발급대상상품
    /// </summary>
    [StringLength(1)]
    public string issue_product_binding_type { get; set; } = null!;

    /// <summary>
    /// 발급대상카테고리
    /// </summary>
    [StringLength(1)]
    public string issue_category_binding_type { get; set; } = null!;

    /// <summary>
    /// 최소구매수량
    /// </summary>
    [StringLength(255)]
    public string issue_ord_min_count { get; set; } = null!;

    /// <summary>
    /// 사용기간설정
    /// </summary>
    [StringLength(1)]
    public string use_available_period_type { get; set; } = null!;

    /// <summary>
    /// 사용가능 시작일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? use_available_start_day { get; set; }

    /// <summary>
    /// 사용가능 종료일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? use_available_end_day { get; set; }

    /// <summary>
    /// 사용기간
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int use_available_day_from { get; set; }

    /// <summary>
    /// 사용범위
    /// </summary>
    [StringLength(10)]
    public string use_domain_type_serial { get; set; } = null!;

    /// <summary>
    /// 적용가능범위
    /// </summary>
    [StringLength(1)]
    public string use_level_type { get; set; } = null!;

    /// <summary>
    /// 쿠폰적용 상품 타입
    /// </summary>
    [StringLength(1)]
    public string use_product_binding_type { get; set; } = null!;

    /// <summary>
    /// 쿠폰적용 카테고리타입
    /// </summary>
    [StringLength(1)]
    public string use_category_binding_type { get; set; } = null!;

    /// <summary>
    /// 사용가능기준
    /// </summary>
    [StringLength(1)]
    public string use_available_price_type { get; set; } = null!;

    [StringLength(1)]
    public string use_available_price_detail_type { get; set; } = null!;

    /// <summary>
    /// 사용가능 최소금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int use_available_min_price { get; set; }

    /// <summary>
    /// 사용가능기준수량(U:제한없음/O:주문수량기준/P:상품수량기준)
    /// </summary>
    [StringLength(1)]
    public string use_available_qty_type { get; set; } = null!;

    /// <summary>
    /// 사용가능 최소수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int use_available_min_qty { get; set; }

    /// <summary>
    /// 사용가능 수량 범위 (lt:이하, gt:이상, equal:같음)
    /// </summary>
    [StringLength(10)]
    public string? qty_range { get; set; }

    /// <summary>
    /// 사용가능결제수단
    /// </summary>
    [StringLength(50)]
    public string use_pay_method_binding_type { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
