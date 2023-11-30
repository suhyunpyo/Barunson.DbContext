using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class BSTORE_DAILY_MMS
{
    [StringLength(10)]
    [Unicode(false)]
    public string send_dt { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;
}
