using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("coupon_code", "use_type")]
public partial class ewed_coupon
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    public int? order_seq { get; set; }

    public short coupon_price { get; set; }

    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string use_type { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isUsable { get; set; }

    public int seq_num { get; set; }
}
