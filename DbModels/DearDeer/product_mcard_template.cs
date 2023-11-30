using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 상품-모바일청첩장 릴레이션
/// </summary>
[Keyless]
[MySqlCollation("utf8_unicode_ci")]
public partial class product_mcard_template
{
    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint product_id { get; set; }

    /// <summary>
    /// mobile_card_templates.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint mobile_card_template_id { get; set; }
}
