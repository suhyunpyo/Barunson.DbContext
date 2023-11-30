using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class deardeer_product
{
    [StringLength(30)]
    [Unicode(false)]
    public string? code { get; set; }

    public int? price { get; set; }
}
