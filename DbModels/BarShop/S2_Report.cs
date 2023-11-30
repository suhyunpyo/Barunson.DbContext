using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_Report
{
    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    public int? cuchun { get; set; }

    public int? cuchunRate { get; set; }

    public int? prodCuchun { get; set; }

    public int? zzim { get; set; }
}
