using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 콜센터 로그
/// </summary>
public partial class Callcenter_Log
{
    [Key]
    public int id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string YIVR { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? YMENU { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime YRDATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? YCallerID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }
}
