using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CouponCD", "CouponNum")]
public partial class tCouponSub_SmartAD
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string CouponCD { get; set; } = null!;

    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string CouponNum { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string? UserID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? UserEmail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TakeYN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TakeDT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? UseYN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UseDT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? userDelYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? sendMailYN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertDT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? TimeCD { get; set; }
}
