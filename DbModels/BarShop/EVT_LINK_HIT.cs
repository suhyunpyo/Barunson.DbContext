using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class EVT_LINK_HIT
{
    [StringLength(10)]
    [Unicode(false)]
    public string inflow { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string route { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime regdate { get; set; }
}
