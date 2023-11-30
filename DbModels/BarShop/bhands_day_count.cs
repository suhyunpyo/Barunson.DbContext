using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class bhands_day_count
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? day { get; set; }

    public int? bhands_join_total { get; set; }

    public int? bhands_join_web { get; set; }

    public int? bhands_join_mobile { get; set; }

    public int? bhands_membership_total { get; set; }

    public int? bhands_membership_join { get; set; }

    public int? bhands_membership_modify { get; set; }

    public int? bhands_membership_apay { get; set; }

    public int? bhands_membership_X { get; set; }

    public int? bhands_membership_percent { get; set; }
}
