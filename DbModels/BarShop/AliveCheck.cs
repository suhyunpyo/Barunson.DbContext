using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 실사용자확인
/// </summary>
[Keyless]
public partial class AliveCheck
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Site_Gubun { get; set; }

    public short Cnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Gubun { get; set; } = null!;
}
