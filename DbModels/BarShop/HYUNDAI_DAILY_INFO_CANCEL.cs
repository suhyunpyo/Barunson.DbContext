using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class HYUNDAI_DAILY_INFO_CANCEL
{
    [StringLength(10)]
    [Unicode(false)]
    public string? CANCEL_DT { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UNAME { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? HAND_PHONE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CREATE_DATE { get; set; }
}
