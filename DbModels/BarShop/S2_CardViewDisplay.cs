using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_CardViewDisplay
{
    public int Card_Seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Card_Code { get; set; } = null!;

    public int? company_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isDisplay { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isJumun { get; set; }
}
