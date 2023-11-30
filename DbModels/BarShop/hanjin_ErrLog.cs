using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 한진택배 오류
/// </summary>
[Keyless]
public partial class hanjin_ErrLog
{
    [StringLength(1)]
    [Unicode(false)]
    public string order_type { get; set; } = null!;

    public int kid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string del_code { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? err_msg { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    public int id { get; set; }
}
