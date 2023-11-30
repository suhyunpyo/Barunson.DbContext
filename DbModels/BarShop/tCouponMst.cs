using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// (old) 더카드 쿠폰
/// </summary>
public partial class tCouponMst
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string CouponCD { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? Cd { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Subject { get; set; }

    public int? Amt { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? amtGb { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FromDT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ToDT { get; set; }

    public int? ValidAmt { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CouponURL { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? AddFile { get; set; }

    public int? TakeCNT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertDT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? UseYN { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? UseStoreCD { get; set; }

    public int? LimitCnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EmpYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MultiUseYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string MobileOnlyYN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? LimitAmtChkYN { get; set; }

    public int? LimitAmt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? UseTarget { get; set; }

    public int? CouponCnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? partnerYN { get; set; }

    /// <summary>
    /// 배송비 지원쿠폰 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DeliveryYN { get; set; } = null!;

    /// <summary>
    /// 발급일기준
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string IssueYN { get; set; } = null!;

    /// <summary>
    /// 발급일기준 몇일까지인가..
    /// </summary>
    public byte IssueDayCnt { get; set; }

    /// <summary>
    /// 대상품목 자동등록 여부 ( A : 자동, M : 수동 )
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string TermType { get; set; } = null!;

    /// <summary>
    /// 조건설정_마진율
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string TermMarginUseYN { get; set; } = null!;

    /// <summary>
    /// 기준마진율
    /// </summary>
    public byte TermMargin { get; set; }

    /// <summary>
    /// 조건설정_특정상품지정
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string TermItemUseYN { get; set; } = null!;

    /// <summary>
    /// 조건설정_특정업체지정
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string TermVndUseYN { get; set; } = null!;

    /// <summary>
    /// 조건설정_특정이벤트지정
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string TermEventUseYN { get; set; } = null!;

    /// <summary>
    /// 조건설정_특정카테고리지정
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string TermCategoryUseYN { get; set; } = null!;

    /// <summary>
    /// 조건설정_특정브랜드
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string TermBrandUseYN { get; set; } = null!;

    /// <summary>
    /// 쿠폰적용여부 ( ONLY : 한상품만, MULTI : 제한없음 )
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string ApplyType { get; set; } = null!;

    /// <summary>
    /// 배송비쿠폰설정 - 다른쿠폰과 중복사용 가능한가..
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DeliveryOverSaleYN { get; set; } = null!;

    /// <summary>
    /// 판매단가 제한여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string LimitSalePriceUseYN { get; set; } = null!;

    /// <summary>
    /// 판매단가 ~ 이상일경우 사용가능
    /// </summary>
    public int LimitSalePrice { get; set; }

    /// <summary>
    /// 지정상품 사용여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string LimitSaleItemYN { get; set; } = null!;

    /// <summary>
    /// 지정상품설정
    /// </summary>
    [StringLength(12)]
    [Unicode(false)]
    public string? LimitSaleItemCD { get; set; }

    /// <summary>
    /// 지정상품 몇개이상 구매시 이용가능한지..
    /// </summary>
    public int LimitSaleItemCnt { get; set; }

    [StringLength(1)]
    public string? SalePriceViewYN { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CoverageComment { get; set; }
}
