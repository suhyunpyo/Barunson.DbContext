using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class MEMPLUS_DAILY_INFO_CANCEL
{
    [StringLength(10)]
    [Unicode(false)]
    public string file_dt { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string cancel_dt { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string hphone { get; set; } = null!;
}
