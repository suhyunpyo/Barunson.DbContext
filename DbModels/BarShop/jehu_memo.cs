using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class jehu_memo
{
    [StringLength(900)]
    [Unicode(false)]
    public string? contents { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime updated_tmstmp { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string display_yorn { get; set; } = null!;
}
