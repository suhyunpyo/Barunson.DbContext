using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("uid", Name = "IX_KT_DAILY_INFO_CANCEL_uid")]
public partial class KT_DAILY_INFO_CANCEL
{
    [StringLength(10)]
    [Unicode(false)]
    public string? cancel_dt { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? hand_phone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? create_Date { get; set; }
}
