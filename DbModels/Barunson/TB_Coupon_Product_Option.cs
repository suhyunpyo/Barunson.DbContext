using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 쿠폰_상품_옵션
/// </summary>
public partial class TB_Coupon_Product_Option
{
    /// <summary>
    /// 쿠폰_상품_옵션_ID
    /// </summary>
    [Key]
    public int Coupon_Product_Option_ID { get; set; }

    /// <summary>
    /// 쿠폰_상품_ID
    /// </summary>
    public int? Coupon_Product_ID { get; set; }

    /// <summary>
    /// 옵션_명
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? Option_Name { get; set; }

    /// <summary>
    /// 옵션_값
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? Option_Value { get; set; }

    [ForeignKey("Coupon_Product_ID")]
    [InverseProperty("TB_Coupon_Product_Option")]
    public virtual TB_Coupon_Product? Coupon_Product { get; set; }
}
