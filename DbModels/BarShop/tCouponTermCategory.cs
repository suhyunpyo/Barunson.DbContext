using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CouponCD", "CatLCD", "CatMCD", "CatSCD", "CatVCD")]
public partial class tCouponTermCategory
{
    public int Idx { get; set; }

    [Key]
    [StringLength(8)]
    [Unicode(false)]
    public string CouponCD { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string CatLCD { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string CatMCD { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string CatSCD { get; set; } = null!;

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string CatVCD { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ProcType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InsertDT { get; set; }
}
