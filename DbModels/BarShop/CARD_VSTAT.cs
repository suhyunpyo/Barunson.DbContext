using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("vdate", "card_Seq", "card_type")]
public partial class CARD_VSTAT
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string vdate { get; set; } = null!;

    [Key]
    public int card_Seq { get; set; }

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string card_type { get; set; } = null!;

    public int vcnt { get; set; }
}
