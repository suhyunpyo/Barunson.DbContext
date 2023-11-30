using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_EventMusic_Str_Temp
{
    public byte seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string event_title { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string start_date { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string end_date { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? event_url { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public int? view_cnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? duplication_yn { get; set; }
}
