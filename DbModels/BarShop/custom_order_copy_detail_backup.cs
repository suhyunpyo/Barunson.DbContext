using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("order_seq", Name = "IX_custom_order_copy_detail_backup_order_seq")]
public partial class custom_order_copy_detail_backup
{
    public long id { get; set; }

    public int order_seq { get; set; }

    public byte delivery_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? item_type { get; set; }

    public short item_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isPItem { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string item_title { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string item_code { get; set; } = null!;

    public short item_count { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? etc1 { get; set; }

    public short? pack_count { get; set; }

    public int? pack_weight { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
