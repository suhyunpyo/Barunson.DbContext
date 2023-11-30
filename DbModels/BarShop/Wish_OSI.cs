using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class Wish_OSI
{
    public double? card_code { get; set; }

    [StringLength(255)]
    public string? card_osi { get; set; }

    [StringLength(255)]
    public string? card_size { get; set; }

    [StringLength(255)]
    public string? card_osi_result { get; set; }
}
