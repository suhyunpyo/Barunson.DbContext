using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CouponCD", "ItemCD")]
public partial class tCouponUseItem
{
    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string CouponCD { get; set; } = null!;

    [Key]
    [StringLength(12)]
    [Unicode(false)]
    public string ItemCD { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? InsertDT { get; set; }
}
