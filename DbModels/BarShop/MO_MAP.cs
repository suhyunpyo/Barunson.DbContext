using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("MO_MAP", Schema = "invtmng")]
public partial class MO_MAP
{
    [StringLength(20)]
    [Unicode(false)]
    public string? MO_NUMBER { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ALARM_YN { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ALARM_DAY_TIME { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALARM_DAY_RECEIVERS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ALARM_DAY_SENDER { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ALARM_NIGHT_TIME { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ALARM_NIGHT_RECEIVERS { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ALARM_NIGHT_SENDER { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? ALARM_MSG { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AUTO_REPLY_YN { get; set; }

    [StringLength(160)]
    [Unicode(false)]
    public string? AUTO_REPLY_MSG { get; set; }
}
