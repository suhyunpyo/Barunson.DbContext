using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class BRANCH_WISHMADE_UPDATE
{
    public double? CODE { get; set; }

    public double? PRICE { get; set; }

    public double? A { get; set; }

    public double? B { get; set; }

    [StringLength(255)]
    public string? C { get; set; }

    public double? D { get; set; }

    [StringLength(255)]
    public string? E { get; set; }

    public double? F { get; set; }

    public double? G { get; set; }

    [StringLength(255)]
    public string? GUBUN { get; set; }

    public double? is100 { get; set; }

    public double? is200 { get; set; }

    public double? is300 { get; set; }

    public double? is1001 { get; set; }

    public double? is1002 { get; set; }

    public double? is1003 { get; set; }

    public double? is1004 { get; set; }

    public double? is1005 { get; set; }

    public double? is1006 { get; set; }
}
