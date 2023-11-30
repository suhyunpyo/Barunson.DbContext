using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 옵션아이템
/// </summary>
[Index("option_default", Name = "option_default")]
[Index("option_id", Name = "options_items_option_id_foreign")]
[MySqlCollation("utf8_unicode_ci")]
public partial class options_items
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint option_id { get; set; }

    [StringLength(255)]
    public string? item_name { get; set; }

    [StringLength(100)]
    public string? item_code { get; set; }

    [Column(TypeName = "int(11)")]
    public int qty { get; set; }

    public float option_add_price { get; set; }

    [StringLength(255)]
    public string option_mark { get; set; } = null!;

    [Column(TypeName = "tinyint(4)")]
    public sbyte option_default { get; set; }

    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [ForeignKey("option_id")]
    [InverseProperty("options_items")]
    public virtual options option { get; set; } = null!;
}
