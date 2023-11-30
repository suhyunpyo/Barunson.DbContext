using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 시리얼쿠폰-카테고리 릴레이션
/// </summary>
[Keyless]
public partial class serial_coupons_category
{
    /// <summary>
    /// serial_coupon.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint serial_coupons_id { get; set; }

    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint category_id { get; set; }
}
