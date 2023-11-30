using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class temp0307
{
    [StringLength(255)]
    public string? service { get; set; }

    [StringLength(255)]
    public string? phone_num { get; set; }
}
