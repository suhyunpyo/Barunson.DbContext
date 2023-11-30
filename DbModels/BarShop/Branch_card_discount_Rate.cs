using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Branch_card_discount_Rate
{
    [Key]
    public int id { get; set; }

    public int company_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string disrate_type { get; set; } = null!;

    public int card_price { get; set; }

    public short min_count { get; set; }

    public short max_count { get; set; }

    public double discount_rate { get; set; }

    public byte? company { get; set; }
}
