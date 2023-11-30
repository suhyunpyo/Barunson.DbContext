using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이용후기 베스트
/// </summary>
[Keyless]
public partial class S4_Event_ReviewBest
{
    public int best_seq { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string comment { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string best_date { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [ForeignKey("best_seq")]
    public virtual S4_Event_Review best_seqNavigation { get; set; } = null!;
}
