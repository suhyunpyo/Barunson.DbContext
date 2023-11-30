using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 3자동의
/// </summary>
[Index("event_div", "reg_date", Name = "IX_S4_Event_Raina_eventdiv_regdate")]
[Index("uid", Name = "IX_S4_Event_Raina_uid")]
public partial class S4_Event_Raina
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? event_div { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(10)]
    public string? inflow_route { get; set; }
}
