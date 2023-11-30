using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// BEAUTYBOX_ITEM_MST
/// </summary>
public partial class BEAUTYBOX_ITEM_MST
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ITEM_NAME { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ITEM_CODE { get; set; }

    public int? GROUP_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? STOCK_YORN { get; set; }

    public int? STOCK_QTY { get; set; }

    public int? SALE_QTY { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? IDATE { get; set; }
}
