using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 쿠폰마스터 정보
/// </summary>
public partial class COUPON_MST
{
    /// <summary>
    /// SEQ
    /// </summary>
    [Key]
    public int COUPON_MST_SEQ { get; set; }

    /// <summary>
    /// 쿠폰명
    /// </summary>
    [StringLength(50)]
    public string COUPON_NAME { get; set; } = null!;

    /// <summary>
    /// 쿠폰설명(안내문구)
    /// </summary>
    [StringLength(1000)]
    public string COUPON_DESC { get; set; } = null!;

    /// <summary>
    /// 발행개수(0:무제한)
    /// </summary>
    public int COUPON_ISSUE_CNT { get; set; }

    public int DOWNLOAD_MAX_QTY { get; set; }

    /// <summary>
    /// 다운로드 개인별 제한수량(0:제한없음)
    /// </summary>
    public int DOWNLOAD_LIMIT_PER_PERSON_QTY { get; set; }

    /// <summary>
    /// 다운로드된 수량
    /// </summary>
    public int DOWNLOADED_CNT { get; set; }

    /// <summary>
    /// 쿠폰종류(A:기본 B:중복,그오 )
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string COUPON_GROUP_CODE { get; set; } = null!;

    /// <summary>
    /// 쿠폰속성(A:기본 B:중복 C:중중복)
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string COUPON_TYPE_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ORDER_TYPE_CODE { get; set; } = null!;

    /// <summary>
    /// 중복허용여부(Y:가능,N:불가능)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DUP_COUPON_ALLOW_YN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string AD_COUPON_ALLOW_YN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ADD_COUPON_ALLOW_YN { get; set; } = null!;

    /// <summary>
    /// 적용가능주문형태(O:원주문 A:추가주무)
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string ORDER_APPLY_TYPE { get; set; } = null!;

    /// <summary>
    /// 쿠폰유효기간(A:없음, V:가변, P:기간)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string EXPIRY_TYPE { get; set; } = null!;

    /// <summary>
    /// 다운로드 시작일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? EXPIRY_START_DATE { get; set; }

    /// <summary>
    /// 다운로드 종료일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? EXPIRY_END_DATE { get; set; }

    /// <summary>
    /// 가변종료일(발급일로부터의 유효기간)
    /// </summary>
    public int EXPIRY_CUSTOM_VALUE { get; set; }

    /// <summary>
    /// 발급방식(M:수동, A:자동)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DOWNLOAD_KIND { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string? DOWNLOAD_KIND_ETC_CODE { get; set; }

    /// <summary>
    /// 발급대상(A:전체, P:특정[COUPON_APPLY_USER])
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DOWNLOAD_USER_GB { get; set; } = null!;

    /// <summary>
    /// 사용처(ALL :전체, ON:온라인, OFF:오프라인)
    /// </summary>
    [StringLength(5)]
    public string USE_PLACE { get; set; } = null!;

    /// <summary>
    /// 사용가능디바이스(P:PC, M:모바일)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string USE_DEVICE { get; set; } = null!;

    /// <summary>
    /// 할인값
    /// </summary>
    public int DISCOUNT_VALUE { get; set; }

    /// <summary>
    /// 할인방법(W:정액, P:정률)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DISCOUNT_FIXED_RATE_TYPE { get; set; } = null!;

    /// <summary>
    /// 최대할인금액(0:제한없음)
    /// </summary>
    public int DISCOUNT_MAX_AMT { get; set; }

    /// <summary>
    /// 구매제한금액(0:제한없음)
    /// </summary>
    public int ORDER_AMT { get; set; }

    public int ORDER_CNT { get; set; }

    /// <summary>
    /// 가입SITE(구분자:| REFERER_SALES_GUBUN)
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string REFERER_SALES_GUBUN { get; set; } = null!;

    /// <summary>
    /// 가입일 시작
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? USER_REG_START_DATE { get; set; }

    /// <summary>
    /// 가입일 종료
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? USER_REG_END_DATE { get; set; }

    /// <summary>
    /// 결혼예정 시작일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? WEDDING_START_DATE { get; set; }

    /// <summary>
    /// 결혼예정 종료일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? WEDDING_END_DATE { get; set; }

    /// <summary>
    /// 예식지역(구분자 : | )
    /// </summary>
    [StringLength(150)]
    public string WEDD_PLACE { get; set; } = null!;

    /// <summary>
    /// 샘플주문여부
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string SAMPLE_ORDER_TYPE { get; set; } = null!;

    /// <summary>
    /// 샘플주문 시작일(CUSTOM_SAMPLE_ORDER.REQUEST_DATE)
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? SAMPLE_ORDER_START_DATE { get; set; }

    /// <summary>
    /// 샘플주문 종료일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? SAMPLE_ORDER_END_DATE { get; set; }

    /// <summary>
    /// 청첩장주문여부
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string CARD_ORDER_TYPE { get; set; } = null!;

    /// <summary>
    /// 청첩장 주문 구매수
    /// </summary>
    public int CARD_ORDER_CNT { get; set; }

    /// <summary>
    /// 발행기간 시작일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? COUPON_ISSUE_START_DATE { get; set; }

    /// <summary>
    /// 발행기간 종료일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? COUPON_ISSUE_END_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string STATUS_ACTIVE_YN { get; set; } = null!;

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }

    /// <summary>
    /// 등록자
    /// </summary>
    [StringLength(50)]
    public string REG_USER_ID { get; set; } = null!;

    /// <summary>
    /// 수정일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime UPDATE_DATE { get; set; }

    /// <summary>
    /// 수정자
    /// </summary>
    [StringLength(50)]
    public string UPDATE_USER_ID { get; set; } = null!;

    [InverseProperty("COUPON_MST_SEQNavigation")]
    public virtual ICollection<COUPON_APPLY_CARD> COUPON_APPLY_CARD { get; } = new List<COUPON_APPLY_CARD>();

    [InverseProperty("COUPON_MST_SEQNavigation")]
    public virtual ICollection<COUPON_APPLY_SERVICE> COUPON_APPLY_SERVICE { get; } = new List<COUPON_APPLY_SERVICE>();

    [InverseProperty("COUPON_MST_SEQNavigation")]
    public virtual ICollection<COUPON_APPLY_SITE> COUPON_APPLY_SITE { get; } = new List<COUPON_APPLY_SITE>();

    [InverseProperty("COUPON_MST_SEQNavigation")]
    public virtual ICollection<COUPON_APPLY_USER> COUPON_APPLY_USER { get; } = new List<COUPON_APPLY_USER>();

    [InverseProperty("COUPON_MST_SEQNavigation")]
    public virtual ICollection<COUPON_DETAIL> COUPON_DETAIL { get; } = new List<COUPON_DETAIL>();
}
