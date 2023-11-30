using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 할로윈 이벤트
/// </summary>
[Keyless]
public partial class EVT_HOLLOWEEN
{
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public int company_seq { get; set; }

    public int page_num { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
