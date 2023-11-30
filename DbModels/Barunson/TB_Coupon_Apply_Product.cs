using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 쿠폰_적용_상품군
/// </summary>
public partial class TB_Coupon_Apply_Product
{
    /// <summary>
    /// 상품_적용_ID
    /// </summary>
    [Key]
    public int Product_Apply_ID { get; set; }

    public int? Coupon_ID { get; set; }

    [InverseProperty("Product_Apply")]
    public virtual ICollection<TB_Apply_Product> TB_Apply_Product { get; } = new List<TB_Apply_Product>();
}
