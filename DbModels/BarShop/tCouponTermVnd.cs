using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CouponCD", "VndCD")]
public partial class tCouponTermVnd
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string CouponCD { get; set; } = null!;

    [Key]
    [StringLength(7)]
    [Unicode(false)]
    public string VndCD { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ProcType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InsertDT { get; set; }
}
