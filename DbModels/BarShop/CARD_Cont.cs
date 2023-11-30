using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CARD_Cont
{
    public int card_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string cont_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? erp_code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? card_size { get; set; }

    public int carD_price_customer { get; set; }

    public double? card_src_price { get; set; }

    public double? card_branch_price { get; set; }
}
