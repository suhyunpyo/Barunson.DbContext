using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class wish_rate
{
    [StringLength(255)]
    public string? a { get; set; }

    public double? b { get; set; }

    public double? a100 { get; set; }

    public double? a150 { get; set; }

    public double? a200 { get; set; }

    public double? a250 { get; set; }

    public double? a300 { get; set; }

    public double? a350 { get; set; }

    public double? a400 { get; set; }

    public double? a450 { get; set; }

    public double? a500 { get; set; }

    public double? a550 { get; set; }

    public double? a600 { get; set; }

    public double? a650 { get; set; }

    public double? a700 { get; set; }

    public double? a800 { get; set; }

    public double? a900 { get; set; }

    public double? a1000 { get; set; }
}
