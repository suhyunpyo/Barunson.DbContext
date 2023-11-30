using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class tCouponTarget
{
    [StringLength(8)]
    [Unicode(false)]
    public string CouponCD { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string UserID { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? UserEmail { get; set; }

    public int? UserChkNM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertDT { get; set; }
}
