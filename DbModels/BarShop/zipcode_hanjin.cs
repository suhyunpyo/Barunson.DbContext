using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("zipcode_hanjin", Schema = "invtmng")]
public partial class zipcode_hanjin
{
    public double? zipcode { get; set; }

    [StringLength(255)]
    public string? si { get; set; }

    [StringLength(255)]
    public string? gugun { get; set; }

    [StringLength(255)]
    public string? terminal1_dong { get; set; }

    [StringLength(255)]
    public string? terminal1_code { get; set; }

    [StringLength(255)]
    public string? terminal1_name { get; set; }

    [StringLength(255)]
    public string? terminal2_code { get; set; }

    [StringLength(255)]
    public string? terminal2_name { get; set; }

    public double? tm1 { get; set; }

    public double? tm2 { get; set; }

    [StringLength(255)]
    public string? tm3 { get; set; }
}
