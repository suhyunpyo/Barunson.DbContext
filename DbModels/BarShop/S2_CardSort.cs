using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_CardSort
{
    [StringLength(255)]
    public string? Card_Code { get; set; }

    public short? ranking { get; set; }
}
