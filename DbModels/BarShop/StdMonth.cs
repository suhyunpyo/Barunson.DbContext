using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("yyyymm", "LangID")]
public partial class StdMonth
{
    [Key]
    [StringLength(6)]
    public string yyyymm { get; set; } = null!;

    [Key]
    [StringLength(3)]
    public string LangID { get; set; } = null!;

    [StringLength(7)]
    public string yyyymmS { get; set; } = null!;

    [StringLength(20)]
    public string yyyymmName { get; set; } = null!;

    [StringLength(10)]
    public string mmName { get; set; } = null!;

    [StringLength(8)]
    public string MonthStart { get; set; } = null!;

    [StringLength(8)]
    public string MonthEnd { get; set; } = null!;

    public short MonthSerNo { get; set; }

    [StringLength(5)]
    public string yyyyq { get; set; } = null!;
}
