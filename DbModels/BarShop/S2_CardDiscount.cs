using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 할인율정보	
/// </summary>
[PrimaryKey("CardDiscount_Seq", "MinCount", "MaxCount")]
public partial class S2_CardDiscount
{
    [Key]
    public int CardDiscount_Seq { get; set; }

    /// <summary>
    /// 시작 주문수량
    /// </summary>
    [Key]
    public short MinCount { get; set; }

    /// <summary>
    /// 최대 주문수량
    /// </summary>
    [Key]
    public short MaxCount { get; set; }

    /// <summary>
    /// 할인율
    /// </summary>
    [Column(TypeName = "numeric(18, 0)")]
    public decimal? Discount_Rate { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Discount_Price { get; set; }
}
