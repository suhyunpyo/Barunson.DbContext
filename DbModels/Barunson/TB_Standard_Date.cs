using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.Barunson;

/// <summary>
/// 기준_날짜
/// </summary>
public partial class TB_Standard_Date
{
    /// <summary>
    /// 기준_날짜
    /// </summary>
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string Standard_Date { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string? Standard_Month { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Standard_Year { get; set; }
}
