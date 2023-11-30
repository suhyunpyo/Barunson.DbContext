using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("main_card_code", Name = "IX_S2_CardPrintInfo_main_card_code")]
public partial class S2_CardPrintInfo
{
    [Key]
    public int id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string main_card_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string print_type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string print_front { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string print_back { get; set; } = null!;
}
