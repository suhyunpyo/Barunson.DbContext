using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class VW_HALL_SALES_STATICS
{
    public int? company_seq { get; set; }

    public int d30 { get; set; }

    public int d90 { get; set; }

    public int d120 { get; set; }

    public int d360 { get; set; }
}
