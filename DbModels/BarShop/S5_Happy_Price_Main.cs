using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 더카드 할인 회차 관리
/// </summary>
public partial class S5_Happy_Price_Main
{
    [Key]
    public int hp_idx { get; set; }

    [StringLength(200)]
    public string? hp_title { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? hp_Sdate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? hp_Edate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime hp_regdate { get; set; }

    public int hp_status { get; set; }
}
