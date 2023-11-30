using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CHG_ENV_log
{
    public int order_Seq { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime chg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? gubun { get; set; }
}
