using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class weddinghallbest_click
{
    [StringLength(10)]
    [Unicode(false)]
    public string TODAY_DT { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? GUID { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? GUBUN { get; set; }
}
