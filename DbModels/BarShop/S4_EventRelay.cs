using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_EventRelay
{
    public int order_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string relay_uid { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? uid { get; set; }

    public int? relay_order_seq { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? give_status { get; set; }
}
