using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문수량
/// </summary>
[Index("order_no", Name = "idx_order_no")]
[Index("order_item_no", Name = "order_item_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_card_qty
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    [StringLength(30)]
    public string order_no { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int order_item_id { get; set; }

    [StringLength(30)]
    public string order_item_no { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int qty_index { get; set; }

    [Column(TypeName = "int(11)")]
    public int cont_onum1 { get; set; }

    [Column(TypeName = "int(11)")]
    public int cont_onum2 { get; set; }

    [Column(TypeName = "int(11)")]
    public int cont_onum3 { get; set; }

    [Column(TypeName = "int(11)")]
    public int env_onum1 { get; set; }

    [Column(TypeName = "int(11)")]
    public int env_onum2 { get; set; }

    [Column(TypeName = "int(11)")]
    public int env_onum3 { get; set; }

    [Column(TypeName = "int(11)")]
    public int env_onum4 { get; set; }

    [Column(TypeName = "int(11)")]
    public int env_onum_white { get; set; }
}
