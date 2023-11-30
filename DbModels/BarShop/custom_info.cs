using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class custom_info
{
    [StringLength(1)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string order_type { get; set; } = null!;

    public int order_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? cname { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? cphone { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? chphone { get; set; }

    public int status_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? order_date { get; set; }
}
