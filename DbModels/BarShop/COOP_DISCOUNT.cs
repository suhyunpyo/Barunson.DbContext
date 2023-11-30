using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 제휴 할인
/// </summary>
[Keyless]
public partial class COOP_DISCOUNT
{
    [StringLength(1)]
    [Unicode(false)]
    public string disrate_type { get; set; } = null!;

    public int card_seq { get; set; }

    public int company_Seq { get; set; }

    public double discount_rate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime mod_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? cardbrand { get; set; }
}
