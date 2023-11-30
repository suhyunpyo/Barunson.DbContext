using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("order_seq", Name = "IX_custom_order_copy_backup_order_seq")]
public partial class custom_order_copy_backup
{
    public int order_seq { get; set; }

    public byte delivery_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? delivery_method { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? jebon_str { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? embo_str { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? print_str { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isRisk { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isQuick { get; set; } = null!;
}
