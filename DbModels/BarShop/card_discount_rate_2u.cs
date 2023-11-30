using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드할인율
/// </summary>
[Keyless]
public partial class card_discount_rate_2u
{
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string card_Group { get; set; } = null!;

    public byte company { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string disrate_type { get; set; } = null!;

    public int card_price { get; set; }

    public short min_count { get; set; }

    public short max_count { get; set; }

    public double discount_rate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;
}
