using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 프리미어 빈칸이벤트
/// </summary>
public partial class S4_Event_Blank_Keyword
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    public byte? reg_num { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string comment { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public short? ordered { get; set; }
}
