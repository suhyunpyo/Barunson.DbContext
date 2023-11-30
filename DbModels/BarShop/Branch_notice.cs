using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Branch_notice
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    public int viewcnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string div { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime mdate { get; set; }

    public bool State { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string? contents2 { get; set; }
}
