using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CardSet_PriceTemp
{
    [Key]
    [StringLength(30)]
    [Unicode(false)]
    public string Card_Code { get; set; } = null!;

    public int? CardSet_Price { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CardDiscount_Code { get; set; }
}
