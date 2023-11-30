using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 예전모바일방명록
/// </summary>
public partial class S4_mCardBoard
{
    [Key]
    public int Board_Seq { get; set; }

    public int? Order_Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column(TypeName = "text")]
    public string? Contents { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }
}
