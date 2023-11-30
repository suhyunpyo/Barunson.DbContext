using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class printjob_order_seq
{
    public int? order_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? card_code { get; set; }
}
