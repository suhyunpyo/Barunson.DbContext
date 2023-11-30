using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class research_qlist_Detail
{
    public int order_seq { get; set; }

    public int qid { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? ans { get; set; }
}
