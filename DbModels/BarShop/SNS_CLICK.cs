using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class SNS_CLICK
{
    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string device { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string user_ip { get; set; } = null!;

    [StringLength(8)]
    [Unicode(false)]
    public string? visit_dt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? visit_date { get; set; }
}
