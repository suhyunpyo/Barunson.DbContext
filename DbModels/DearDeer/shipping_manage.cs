using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 배송비관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class shipping_manage
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(255)]
    public string? product_type { get; set; }

    [StringLength(255)]
    public string state { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int shipping_free { get; set; }

    [Column(TypeName = "int(11)")]
    public int default_price { get; set; }

    [Column(TypeName = "int(11)")]
    public int add_price { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
