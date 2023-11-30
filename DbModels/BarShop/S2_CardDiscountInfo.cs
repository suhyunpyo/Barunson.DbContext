using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 할인율관리	
/// </summary>
public partial class S2_CardDiscountInfo
{
    /// <summary>
    /// 할인율 키
    /// </summary>
    [Key]
    public int CardDiscount_Seq { get; set; }

    /// <summary>
    /// 관리 코드
    /// </summary>
    [StringLength(30)]
    [Unicode(false)]
    public string? CardDiscount_Code { get; set; }

    /// <summary>
    /// cardbrand
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? CardDiscount_Div { get; set; }

    public int? CardDiscount_Company_SEQ { get; set; }

    public int? CardDiscount_Status { get; set; }

    /// <summary>
    /// R 할인율
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? CardDiscount_Type { get; set; }
}
