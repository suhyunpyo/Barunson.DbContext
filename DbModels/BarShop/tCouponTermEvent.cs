using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CouponCD", "EventIdx")]
public partial class tCouponTermEvent
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string CouponCD { get; set; } = null!;

    [Key]
    public int EventIdx { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ProcType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InsertDT { get; set; }
}
