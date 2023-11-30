using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CARD_DISCOUNT_RATE_WED
{
    [Key]
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string card_group { get; set; } = null!;

    public byte company { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string disrate_type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string card_kind { get; set; } = null!;

    public int card_price { get; set; }

    public short min_count { get; set; }

    public short max_count { get; set; }

    public double discount_rate { get; set; }
}
