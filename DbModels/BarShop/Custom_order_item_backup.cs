using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("order_seq", Name = "IX_Custom_order_item_backup_order_seq")]
public partial class Custom_order_item_backup
{
    public int id { get; set; }

    public int order_seq { get; set; }

    public int card_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string item_type { get; set; } = null!;

    public int? item_count { get; set; }

    public int? item_price { get; set; }

    public double? item_sale_price { get; set; }

    public double? discount_rate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? memo1 { get; set; }

    public int? addnum_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
