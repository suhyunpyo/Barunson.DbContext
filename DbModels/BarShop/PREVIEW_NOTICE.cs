using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 초안관련 고객에게 전달사항
/// </summary>
[Keyless]
public partial class PREVIEW_NOTICE
{
    public int id { get; set; }

    public int order_Seq { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? contents { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    public byte status { get; set; }
}
