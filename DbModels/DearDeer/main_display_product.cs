using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[Keyless]
[MySqlCollation("utf8_unicode_ci")]
public partial class main_display_product
{
    /// <summary>
    /// main_display.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? main_display_id { get; set; }

    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? product_id { get; set; }

    /// <summary>
    /// 정렬
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? sort_order { get; set; }
}
