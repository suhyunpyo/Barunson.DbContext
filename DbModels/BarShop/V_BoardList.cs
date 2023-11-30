using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class V_BoardList
{
    [StringLength(6)]
    [Unicode(false)]
    public string boardid { get; set; } = null!;

    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    public string? writer { get; set; }

    [StringLength(200)]
    public string? title { get; set; }

    [Column(TypeName = "ntext")]
    public string? contents { get; set; }

    public int display_order { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string start_date { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string end_date { get; set; } = null!;

    public int? viewcnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
