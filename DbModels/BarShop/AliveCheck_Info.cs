using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 라이브체크정보
/// </summary>
[Keyless]
public partial class AliveCheck_Info
{
    [StringLength(2)]
    [Unicode(false)]
    public string? Site_Gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sample_Check { get; set; }

    public short? Sample_Time { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Order_Check { get; set; }

    public short? Order_Time { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Settle_Check { get; set; }

    public short? Settle_Time { get; set; }
}
