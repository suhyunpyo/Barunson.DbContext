using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_COUPON_GURIM
{
    [StringLength(20)]
    public string coupon_code { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
