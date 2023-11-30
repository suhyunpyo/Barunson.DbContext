using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class data_dump_dt
{
    [StringLength(10)]
    [Unicode(false)]
    public string dump_dt { get; set; } = null!;
}
