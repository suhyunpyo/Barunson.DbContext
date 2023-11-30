using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문옵션
/// </summary>
[Index("order_item_id", Name = "order_item_id")]
[Index("order_no", Name = "order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_item_options
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(255)]
    public string order_no { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int order_item_id { get; set; }

    [StringLength(50)]
    public string order_item_no { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int option_id { get; set; }

    [StringLength(255)]
    public string option_name { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int option_item_id { get; set; }

    [StringLength(255)]
    public string option_item_name { get; set; } = null!;

    [StringLength(255)]
    public string? option_item_code { get; set; }

    [Column(TypeName = "int(11)")]
    public int option_add_price { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
