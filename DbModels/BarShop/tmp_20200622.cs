using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class tmp_20200622
{
    public int? order_seq { get; set; }

    [StringLength(50)]
    public string? title { get; set; }

    [StringLength(50)]
    public string? printer { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? print_date { get; set; }
}
