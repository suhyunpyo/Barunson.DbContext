using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 시리얼쿠폰
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class serial_coupons
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 쿠폰이름 필수
    /// </summary>
    [StringLength(50)]
    public string? coupon_name { get; set; }

    /// <summary>
    /// 쿠폰설명
    /// </summary>
    [StringLength(255)]
    public string? coupon_desc { get; set; }

    /// <summary>
    /// 쿠폰 사용처
    /// </summary>
    [StringLength(255)]
    public string? use_place { get; set; }

    /// <summary>
    /// coupons.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? linked_coupon_id { get; set; }

    /// <summary>
    /// 혜택구분 필수 &gt;  할인금액 : A, 할인율 : B, 적립금액 : C, 적립율 : D, 기본배송비할인 : E, 즉시 적립 : F, 예치금 지급 : G
    /// </summary>
    [StringLength(50)]
    public string? benefit_type { get; set; }

    /// <summary>
    /// 혜택구분 기본배송비 할인일때 &gt; 전액할인 : E, 할인율 : I, 할인금액 : H
    /// </summary>
    [StringLength(1)]
    public string? benefit_sub_type { get; set; }

    /// <summary>
    /// 혜택금액 금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int benefit_price { get; set; }

    /// <summary>
    /// 혜택구분 퍼센트
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte benefit_percent { get; set; }

    /// <summary>
    /// 퍼센트 절사 : 절사안함 : 0.1, 1 : 1, 10 : 10, 100 : 100, 1000 : 1000
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int benefit_round_unit { get; set; }

    /// <summary>
    /// 혜택구분 최대금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int benefit_max_price { get; set; }

    /// <summary>
    /// 지역별 배송비 포함여부 &gt;  포함 : T,  미포함 : F
    /// </summary>
    [StringLength(1)]
    public string? include_region_shipping_fee { get; set; }

    /// <summary>
    /// 해외배송 포함여부 &gt;  포함 : T,  미포함 : F
    /// </summary>
    [StringLength(1)]
    public string? include_foreign_delivery { get; set; }

    /// <summary>
    /// 동일인 재발급 여부 &gt;  불가능 : F,  가능 : T
    /// </summary>
    [StringLength(1)]
    public string? is_max_issue_count_for_user { get; set; }

    /// <summary>
    /// 동일인 재발급 수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? max_issue_count_for_user { get; set; }

    /// <summary>
    /// 사용 기간 : 기간기간 설정 : F, 쿠폰 발급일 기준 : R, 쿠폰 발급 당월 말일까지 : M
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
    /// 사용가능 ~ 일간
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int use_available_day_from { get; set; }

    /// <summary>
    /// 사용범위  (PC: W, 모바일: M) 
    /// </summary>
    [StringLength(10)]
    public string use_domain_type_serial { get; set; } = null!;

    /// <summary>
    /// 적용범위 ( 주문서쿠폰:O, 상품 쿠폰:P )
    /// </summary>
    [StringLength(1)]
    public string use_level_type { get; set; } = null!;

    /// <summary>
    /// 쿠폰적용상품 선택 (모두 적용:U, 선택한 상품 적용:I, 선택한 상품 제외하고 적용:E)
    /// </summary>
    [StringLength(1)]
    public string use_product_binding_type { get; set; } = null!;

    /// <summary>
    /// 쿠폰적용 카테고리선택 (모두 적용:U, 선택한 분류 적용:I, 선택한 분류 제외하고 적용:E)
    /// </summary>
    [StringLength(1)]
    public string use_category_binding_type { get; set; } = null!;

    /// <summary>
    /// 사용가능 기준금액 (제한 없음:U, 주문 금액 기준:O, 상품 금액 기준:P)
    /// </summary>
    [StringLength(1)]
    public string use_available_price_type { get; set; } = null!;

    /// <summary>
    /// 사용가능 기준금액 (모든 상품의 주문 금액:U, 쿠폰 적용 상품의 주문 금액:I)
    /// </summary>
    [StringLength(1)]
    public string use_available_price_detail_type { get; set; } = null!;

    /// <summary>
    /// 사용가능 기준금액 (모든 상품의 주문 금액:U, 쿠폰 적용 상품의 주문 금액:I)
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int use_available_min_price { get; set; }

    /// <summary>
    /// 적용 계산 기준 &gt; 할인(쿠폰 제외) 적용 전 결제 금액 : E, 할인(쿠폰 제외) 적용 후 결제 금액 : I
    /// </summary>
    [StringLength(1)]
    public string? issue_for_price_calculate { get; set; }

    /// <summary>
    /// 동일쿠폰사용 설정 (주문서당 n개 까지 사용가능)
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int max_use_count_for_order { get; set; }

    /// <summary>
    /// 사용가능 결제수단 (무통장입금: R, 가상계좌: E, 카드결제: C,   실시간계좌이체: A, 휴대폰결제: H)
    /// </summary>
    [StringLength(255)]
    public string? use_pay_method_binding_type { get; set; }

    /// <summary>
    /// 시리얼 번호 생성 방법자동 생성 : A, 직접 등록 : M, 엑셀 업로드 : E
    /// </summary>
    [StringLength(1)]
    public string? serial_gen_method { get; set; }

    /// <summary>
    /// 시리얼 번호 생성 방법자동 생성 : 10 : 10, 11 : 11, 12 : 12, 13 : 13, 14 : 14, 15 : 15, 16 : 16, 17 : 17, 18 : 18, 19 : 19, 20 : 20, 21 : 21, 22 : 22, 23 : 23, 24 : 24, 25 : 25, 26 : 26, 27 : 27, 28 : 28, 29 : 29, 30 : 30, 31 : 31, 32 : 32, 33 : 33, 34 : 34, 35 : 35
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte serial_no_length { get; set; }

    /// <summary>
    /// 시리얼 번호 생성 기준 &gt; 랜덤 번호 생성 : R,  동일 번호 생성 : S
    /// </summary>
    [StringLength(1)]
    public string? serial_no_type { get; set; }

    /// <summary>
    /// 쿠폰 직접 등록
    /// </summary>
    [Column(TypeName = "text")]
    public string? coupon_direct { get; set; }

    /// <summary>
    /// 최대 발급 수량 설정 필수
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int max_issue_count { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
