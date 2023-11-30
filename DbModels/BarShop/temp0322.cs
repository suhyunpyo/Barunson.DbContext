using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class temp0322
{
    public double? seq { get; set; }

    [StringLength(255)]
    public string? gubun { get; set; }

    [StringLength(255)]
    public string? card_code { get; set; }

    public double? card_seq { get; set; }

    [StringLength(255)]
    public string? ViewYN { get; set; }
}
