using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class WeddingHall_Log
{
    public int id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? gubun { get; set; }

    public int key_idx { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    public string? note { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
