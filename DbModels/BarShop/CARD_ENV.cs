using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 봉투정보
/// </summary>
[Keyless]
public partial class CARD_ENV
{
    public int card_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string env_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? erp_code { get; set; }

    public int print_size { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? card_size { get; set; }

    public int carD_price_customer { get; set; }

    public double? card_src_price { get; set; }

    public double? card_branch_price { get; set; }
}
