using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class coupon_complete_log
{
    public int? order_seq { get; set; }

    public int? last_total_price { get; set; }

    public int? reduce_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
