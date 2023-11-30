using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class metingg
{
    [StringLength(255)]
    public string? card_seq { get; set; }

    [StringLength(255)]
    public string? company_seq { get; set; }

    [StringLength(255)]
    public string? card_price { get; set; }
}
