using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 옵션-상품 릴레이션
/// </summary>
[Keyless]
[Index("option_id", Name = "option_product_option_id_foreign")]
[Index("product_id", Name = "option_product_product_id_foreign")]
[MySqlCollation("utf8_unicode_ci")]
public partial class option_product
{
    [Column(TypeName = "int(10) unsigned")]
    public uint option_id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint product_id { get; set; }

    [ForeignKey("option_id")]
    public virtual options option { get; set; } = null!;

    [ForeignKey("product_id")]
    public virtual products product { get; set; } = null!;
}
