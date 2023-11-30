using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CJ_DELCODE_ERROR
{
    public int? idx { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? code { get; set; }
}
