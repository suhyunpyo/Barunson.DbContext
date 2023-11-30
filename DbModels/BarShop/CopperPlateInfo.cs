using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("card_seq", "isFPrint")]
public partial class CopperPlateInfo
{
    [Key]
    public int card_seq { get; set; }

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string isFPrint { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? card_code { get; set; }

    public int? pCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regdate { get; set; }

    public int? bCount { get; set; }
}
