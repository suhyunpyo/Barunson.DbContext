using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_CopyItem
{
    public long id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? item_type { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string item_title { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string plc_code { get; set; } = null!;

    public short item_count { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string item_code { get; set; } = null!;

    public short item_seq { get; set; }

    public int order_seq { get; set; }

    public byte delivery_seq { get; set; }
}
