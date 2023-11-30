using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 쿠폰-카테고리 릴레이션
/// </summary>
[Keyless]
[MySqlCollation("utf8_unicode_ci")]
public partial class coupons_category
{
    /// <summary>
    /// coupons.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint coupons_id { get; set; }

    /// <summary>
    /// category.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint category_id { get; set; }

    /// <summary>
    /// I:발급대상/U:쿠폰적용
    /// </summary>
    [StringLength(1)]
    public string type { get; set; } = null!;
}
