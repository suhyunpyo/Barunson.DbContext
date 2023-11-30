using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 예전모바일청첩장
/// </summary>
public partial class S5_nmCardBoard
{
    [Key]
    public int Board_Seq { get; set; }

    public int? Order_Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column(TypeName = "text")]
    public string? Contents { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IP { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? HTTP_USER_AGENT { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }
}
