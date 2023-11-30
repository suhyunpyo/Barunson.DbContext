using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CUCKOOS_DAILY_INFO_CANCEL
{
    [StringLength(10)]
    [Unicode(false)]
    public string? file_dt { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? cancel_dt { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? hand_phone { get; set; }
}
