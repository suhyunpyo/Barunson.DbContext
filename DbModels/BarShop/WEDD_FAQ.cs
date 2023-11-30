using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 고객FAQ
/// </summary>
public partial class WEDD_FAQ
{
    [Key]
    public int seq { get; set; }

    public short display_order { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [StringLength(3000)]
    [Unicode(false)]
    public string contents { get; set; } = null!;

    public byte div { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime mdate { get; set; }

    public int COMPANY_SEQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isBest { get; set; } = null!;
}
