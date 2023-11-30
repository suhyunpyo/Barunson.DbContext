using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("vdate", "company_seq", "inout")]
public partial class COOP_VSTAT
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string vdate { get; set; } = null!;

    [Key]
    public short company_seq { get; set; }

    /// <summary>
    /// 0:in, 1:out
    /// </summary>
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string inout { get; set; } = null!;

    public int vcnt { get; set; }
}
