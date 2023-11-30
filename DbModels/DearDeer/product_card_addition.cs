using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// product-invitation_card_addition 릴레이션
/// </summary>
[Keyless]
[MySqlCollation("utf8_unicode_ci")]
public partial class product_card_addition
{
    /// <summary>
    /// invitation_card_addition.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint addition_id { get; set; }

    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint product_id { get; set; }

    /// <summary>
    /// T: ticket, S: sticker
    /// </summary>
    [StringLength(5)]
    public string type { get; set; } = null!;

    /// <summary>
    /// 유료여부
    /// </summary>
    [StringLength(1)]
    public string? use_charge { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
