using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class jehu_no_coupon_event
{
    [Key]
    public int seq { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string start_dt { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string end_dt { get; set; } = null!;

    public int md_Seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string event_yn { get; set; } = null!;
}
