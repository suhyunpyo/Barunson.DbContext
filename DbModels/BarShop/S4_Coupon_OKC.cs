using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_Coupon_OKC
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ckey { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isYN { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? use_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isAdminYN { get; set; }
}
