using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class temp190405
{
    [StringLength(255)]
    public string? service { get; set; }

    [StringLength(255)]
    public string? phone_num { get; set; }

    public double? send_dt { get; set; }

    [StringLength(255)]
    public string? send_chk { get; set; }
}
