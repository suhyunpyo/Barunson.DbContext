using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// barunson_day_count
/// </summary>
[Keyless]
public partial class barunson_day_count
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? day { get; set; }

    public int? barunson_join_total { get; set; }

    public int? barunson_join_web { get; set; }

    public int? barunson_join_mobile { get; set; }

    public int? barunson_membership_total { get; set; }

    public int? barunson_membership_join { get; set; }

    public int? barunson_membership_modify { get; set; }

    public int? barunson_membership_apay { get; set; }

    public int? barunson_membership_X { get; set; }

    public int? barunson_membership_percent { get; set; }
}
