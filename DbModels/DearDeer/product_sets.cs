using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// (사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class product_sets
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int product_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? child_id { get; set; }

    [StringLength(255)]
    public string discount_mark { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int? discount_price { get; set; }

    [StringLength(255)]
    public string? cutting_mark { get; set; }

    [Column(TypeName = "int(11)")]
    public int? cutting_price { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
