using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("card_code", "rtype")]
public partial class card_design_detail
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    /// <summary>
    /// 1:인+이+일,2:약도,3:교통편,
    /// </summary>
    [Key]
    public short rtype { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isFPrint { get; set; } = null!;

    public short sx { get; set; }

    public short sy { get; set; }

    public short ex { get; set; }

    public short ey { get; set; }

    /// <summary>
    /// 0:&quot;중앙,1:왼쪽,2:오른쪽 정렬
    /// </summary>
    public byte alignment { get; set; }
}
