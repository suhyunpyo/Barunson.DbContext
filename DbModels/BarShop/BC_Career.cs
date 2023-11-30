using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 채용관련
/// </summary>
public partial class BC_Career
{
    [Key]
    public int Career_Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Subject { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? SubTitle { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Position { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Hidden { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string AnyTime { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }
}
