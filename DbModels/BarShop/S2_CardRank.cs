using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_CardRank
{
    public int? Card_Seq { get; set; }

    public int? Company_Seq { get; set; }

    public int? Rank { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Rank_UpDown { get; set; }

    public byte? Rank_Change { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Rank_Div { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }
}
