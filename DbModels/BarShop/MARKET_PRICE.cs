using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class MARKET_PRICE
{
    [StringLength(50)]
    [Unicode(false)]
    public string? AA { get; set; }

    public double? BB { get; set; }
}
