using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class PHOTOBOOK_FAQ
{
    public int seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string site_code { get; set; } = null!;

    public short display_order { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    public byte div { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime mdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isBest { get; set; } = null!;
}
