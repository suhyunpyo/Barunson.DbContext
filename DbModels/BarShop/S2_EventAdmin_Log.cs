using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_EventAdmin_Log
{
    [Key]
    public int seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string admin_memo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? charge_use { get; set; }

    public int? charge_use_seq { get; set; }

    public int? charge_use_num { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
