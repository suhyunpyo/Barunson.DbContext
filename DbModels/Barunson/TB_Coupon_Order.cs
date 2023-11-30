using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 쿠폰_주문
/// </summary>
public partial class TB_Coupon_Order
{
    /// <summary>
    /// 쿠폰_주문_ID
    /// </summary>
    [Key]
    public int Coupon_Order_ID { get; set; }

    /// <summary>
    /// 쿠폰_상품_ID
    /// </summary>
    public int? Coupon_Product_ID { get; set; }

    /// <summary>
    /// 쿠폰_주문번호
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Coupon_OrderNumber { get; set; }

    /// <summary>
    /// 콜백_전화번호
    /// </summary>
    [StringLength(11)]
    [Unicode(false)]
    public string? Callback_PhoneNumber { get; set; }

    /// <summary>
    /// 전화번호
    /// </summary>
    [StringLength(11)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// 옵션_코드
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string? Option_Code { get; set; }

    /// <summary>
    /// 등록_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Regist_DateTime { get; set; }

    /// <summary>
    /// 등록_사용자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Regist_User_ID { get; set; }

    /// <summary>
    /// 요청_수
    /// </summary>
    public int? Request_Count { get; set; }

    /// <summary>
    /// 결과_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Result_DateTime { get; set; }

    /// <summary>
    /// 결과_코드
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? Result_Code { get; set; }

    /// <summary>
    /// 결과_내용
    /// </summary>
    [StringLength(100)]
    public string? Result_Content { get; set; }

    /// <summary>
    /// 핀_번호
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? PIN_Number { get; set; }

    /// <summary>
    /// 선물_거래_번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Futures_Trading_Number { get; set; }

    /// <summary>
    /// 쿠폰_만료_일시
    /// </summary>
    [StringLength(14)]
    [Unicode(false)]
    public string? Coupon_Expiration_DateTime { get; set; }

    /// <summary>
    /// 인지국
    /// </summary>
    [StringLength(20)]
    public string? StampOffice { get; set; }

    /// <summary>
    /// 인지세_코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Stamp_Code { get; set; }

    /// <summary>
    /// 인지세_구분
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string? Stamp_Type { get; set; }

    /// <summary>
    /// 핀_부가_정보
    /// </summary>
    [StringLength(40)]
    [Unicode(false)]
    public string? PIN_Option_Information { get; set; }

    [ForeignKey("Coupon_Product_ID")]
    [InverseProperty("TB_Coupon_Order")]
    public virtual TB_Coupon_Product? Coupon_Product { get; set; }

    [InverseProperty("Coupon_Order")]
    public virtual ICollection<TB_Remit> TB_Remit { get; } = new List<TB_Remit>();
}
