using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("company_seq", "card_seq")]
public partial class Branch_card_display
{
    [Key]
    public int company_seq { get; set; }

    [Key]
    public int card_seq { get; set; }

    public int? sales_ranking { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string best_yes_or_no { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? disrate_type { get; set; }
}
