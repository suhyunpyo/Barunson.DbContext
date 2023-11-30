using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 휴일 관리
/// </summary>
public partial class S4_Holiday
{
    [Key]
    public int SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? END_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TYPE { get; set; }
}
