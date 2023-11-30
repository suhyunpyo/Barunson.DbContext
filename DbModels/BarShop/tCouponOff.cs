using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CouponCD", "OffCD")]
public partial class tCouponOff
{
    [Key]
    [StringLength(4)]
    [Unicode(false)]
    public string CouponCD { get; set; } = null!;

    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string OffCD { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? PrintYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TakeYN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TakeDT { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string? CouponNum { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertDT { get; set; }
}
