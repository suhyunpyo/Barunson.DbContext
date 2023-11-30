using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("card_seq", "card_type", "vdate", "company_seq")]
public partial class VSTAT_CARD
{
    [Key]
    public int card_seq { get; set; }

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string card_type { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string vdate { get; set; } = null!;

    public int vcnt { get; set; }

    [Key]
    public short company_seq { get; set; }
}
