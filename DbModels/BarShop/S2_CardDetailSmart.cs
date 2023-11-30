using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CardDetailSmart
{
    [Key]
    public int card_seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string card_category { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isNew { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isBest { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isPlan { get; set; } = null!;

    [StringLength(50)]
    public string? composition { get; set; }

    [StringLength(500)]
    public string? summary { get; set; }

    [StringLength(500)]
    public string? origin { get; set; }

    [StringLength(200)]
    public string? etc1 { get; set; }

    [StringLength(200)]
    public string? etc2 { get; set; }

    public int? min_onum { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str3 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str4 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str5 { get; set; }

    public int? card_sale_price { get; set; }
}
