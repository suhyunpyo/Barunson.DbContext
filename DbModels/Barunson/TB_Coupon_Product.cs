using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 쿠폰_상품
/// </summary>
public partial class TB_Coupon_Product
{
    /// <summary>
    /// 쿠폰_상품_ID
    /// </summary>
    [Key]
    public int Coupon_Product_ID { get; set; }

    /// <summary>
    /// 상품_ID
    /// </summary>
    [StringLength(6)]
    [Unicode(false)]
    public string? Product_ID { get; set; }

    /// <summary>
    /// 상품_구분
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Product_Type { get; set; }

    /// <summary>
    /// 상품_분류
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Product_Category { get; set; }

    /// <summary>
    /// 교환처
    /// </summary>
    [StringLength(100)]
    public string? Affiliate { get; set; }

    /// <summary>
    /// 교환처_분류
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string? Affiliate_Category { get; set; }

    /// <summary>
    /// 대표_교환처_코드
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string? Delegate_Affiliate_Code { get; set; }

    /// <summary>
    /// 상품_설명
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Product_Description { get; set; }

    /// <summary>
    /// 상품_명
    /// </summary>
    [StringLength(100)]
    public string? Product_Name { get; set; }

    /// <summary>
    /// 이미지_경로
    /// </summary>
    [StringLength(255)]
    [Unicode(false)]
    public string? Image_Path { get; set; }

    /// <summary>
    /// 소비자_가격
    /// </summary>
    public int? Retail_Price { get; set; }

    /// <summary>
    /// 소비자_가격_부가세
    /// </summary>
    public int? Retail_Price_Tax { get; set; }

    /// <summary>
    /// 판매_가격
    /// </summary>
    public int? Sale_Price { get; set; }

    /// <summary>
    /// 판매_가격_부가세
    /// </summary>
    public int? Sale_Price_Tax { get; set; }

    /// <summary>
    /// 전체_가격
    /// </summary>
    public int? Total_Price { get; set; }

    /// <summary>
    /// 판매_종료_날짜
    /// </summary>
    [StringLength(8)]
    [Unicode(false)]
    public string? Sale_End_Date { get; set; }

    /// <summary>
    /// 유효_기간
    /// </summary>
    [StringLength(8)]
    [Unicode(false)]
    public string? Valid_Period { get; set; }

    /// <summary>
    /// 배송지_URL
    /// </summary>
    [StringLength(255)]
    [Unicode(false)]
    public string? Destination_URL { get; set; }

    [InverseProperty("Coupon_Product")]
    public virtual ICollection<TB_Coupon_Order> TB_Coupon_Order { get; } = new List<TB_Coupon_Order>();

    [InverseProperty("Coupon_Product")]
    public virtual ICollection<TB_Coupon_Product_Option> TB_Coupon_Product_Option { get; } = new List<TB_Coupon_Product_Option>();
}
