using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class card_discount_season
{
    public int id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string produce_year { get; set; } = null!;

    public byte company { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string disrate_type { get; set; } = null!;

    public int card_price { get; set; }

    public double? disrate50 { get; set; }

    public double? disrate100 { get; set; }

    public double? disrate120 { get; set; }

    public double? disrate150 { get; set; }

    public double? disrate160 { get; set; }

    public double? disrate170 { get; set; }

    public double? disrate200 { get; set; }

    public double? disrate250 { get; set; }

    public double? disrate300 { get; set; }

    public double? disrate350 { get; set; }

    public double? disrate400 { get; set; }

    public double? disrate450 { get; set; }

    public double? disrate500 { get; set; }

    public double? disrate550 { get; set; }

    public double? disrate600 { get; set; }

    public double? disrate650 { get; set; }

    public double? disrate700 { get; set; }

    public double? disrate750 { get; set; }

    public double? disrate800 { get; set; }

    public double? disrate850 { get; set; }

    public double? disrate900 { get; set; }

    public double? disrate950 { get; set; }

    public double? disrate1000 { get; set; }
}
