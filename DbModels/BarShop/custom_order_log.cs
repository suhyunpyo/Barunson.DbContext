using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class custom_order_log
{
    public int? order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? flag { get; set; }

    public byte? settle_Status { get; set; }

    public int? reduce_price { get; set; }

    public int? addition_reduce_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
