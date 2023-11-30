using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 상품-카테고리 릴레이션
/// </summary>
[Keyless]
[MySqlCollation("utf8_unicode_ci")]
public partial class category_product
{
    /// <summary>
    /// categorise.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint category_id { get; set; }

    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint product_id { get; set; }

    /// <summary>
    /// 기본정렬순서
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? sort_order { get; set; }
}
