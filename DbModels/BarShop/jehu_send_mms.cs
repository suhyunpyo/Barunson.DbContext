using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 제휴광고 mms 문자발송
/// </summary>
[Keyless]
[Index("send_Dt", "service", "phone_num", Name = "IDX_Sendmms")]
public partial class jehu_send_mms
{
    [StringLength(2)]
    [Unicode(false)]
    public string service { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string phone_num { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? send_Dt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string send_chk { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? etc_info { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? etc_text { get; set; }
}
