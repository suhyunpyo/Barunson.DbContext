using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 시리얼쿠폰-상품 릴레이션
/// </summary>
[Keyless]
[MySqlCollation("utf8_unicode_ci")]
public partial class serial_coupons_product
{
    /// <summary>
    /// serial_coupon.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint serial_coupon_id { get; set; }

    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint product_id { get; set; }
}
