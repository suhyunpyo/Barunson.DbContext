using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 연휴관리
/// </summary>
public partial class TB_Holiday
{
    [Key]
    public int id { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string hyear { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string hmonth { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string hday { get; set; } = null!;

    public byte? add_d { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? msg { get; set; }
}
