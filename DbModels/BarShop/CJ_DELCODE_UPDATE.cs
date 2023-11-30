using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CJ_DELCODE_UPDATE
{
    [StringLength(1)]
    [Unicode(false)]
    public string? flag { get; set; }

    public int? order_seq { get; set; }

    public int? seq { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? pcode { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? ncode { get; set; }
}
