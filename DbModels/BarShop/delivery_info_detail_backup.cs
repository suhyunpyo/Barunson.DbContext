using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("order_seq", Name = "IX_delivery_info_detail_backup_order_seq")]
public partial class delivery_info_detail_backup
{
    public int ID { get; set; }

    public int order_seq { get; set; }

    public int delivery_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string item_type { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? item_title { get; set; }

    public int item_id { get; set; }

    public int item_count { get; set; }
}
