using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 설문이벤트
/// </summary>
public partial class S4_Poll
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string contents { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string start_date { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string end_date { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string view_div { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? poll_type { get; set; }
}
