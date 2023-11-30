using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_DigitalPhoto
{
    [Key]
    public int id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isUse { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? member_email { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? use_date { get; set; }
}
