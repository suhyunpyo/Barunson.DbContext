using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 인사말
/// </summary>
[Keyless]
public partial class Greeting_barshop
{
    public int GREETING_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string GREETING_NAME { get; set; } = null!;

    [StringLength(3000)]
    [Unicode(false)]
    public string GREETING_CONTENT { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DISPLAY_YES_OR_NO { get; set; } = null!;

    public int? USED_COUNT { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? REGIST_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LAST_UPDATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? RECOMEND_YES_OR_NO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_IMAGE { get; set; }

    public int GREETING_CATEGORY_SEQ { get; set; }
}
