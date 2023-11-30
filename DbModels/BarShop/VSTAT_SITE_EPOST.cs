using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class VSTAT_SITE_EPOST
{
    [StringLength(10)]
    [Unicode(false)]
    public string vdate { get; set; } = null!;

    public int pcnt { get; set; }

    public int ccnt { get; set; }
}
