using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 공휴일관리
/// </summary>
[Keyless]
public partial class holidays
{
    public int YID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string YDisplayName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? YDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? YComment { get; set; }
}
