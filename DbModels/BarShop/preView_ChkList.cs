using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 초안 체크리스트
/// </summary>
[Keyless]
public partial class preView_ChkList
{
    public short lid { get; set; }

    public byte? sid { get; set; }

    public byte? checkNum { get; set; }

    [StringLength(512)]
    [Unicode(false)]
    public string? checkVar { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCard { get; set; }
}
