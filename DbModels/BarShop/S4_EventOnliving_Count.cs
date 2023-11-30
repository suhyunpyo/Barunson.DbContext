using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_EventOnliving_Count
{
    [Key]
    public int seq { get; set; }

    public int? company_seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? gubun { get; set; }

    public int item_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string item_name { get; set; } = null!;

    public int item_count { get; set; }
}
