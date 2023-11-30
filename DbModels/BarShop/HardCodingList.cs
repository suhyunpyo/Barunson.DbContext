using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("HardID", "HardCode")]
public partial class HardCodingList
{
    [Key]
    [StringLength(20)]
    public string HardID { get; set; } = null!;

    [Key]
    [StringLength(30)]
    public string HardCode { get; set; } = null!;

    [Column(TypeName = "numeric(28, 8)")]
    public decimal? DummyNum { get; set; }

    [StringLength(50)]
    public string? DummyField { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string HardUse { get; set; } = null!;

    [StringLength(100)]
    public string? HardDescr { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? MultiUse { get; set; }
}
