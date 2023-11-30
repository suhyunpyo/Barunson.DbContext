using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CONNECT
{
    public int idx { get; set; }

    public long? main1 { get; set; }

    public long? main2 { get; set; }

    public long? detail { get; set; }

    public long? detail2 { get; set; }

    public long? cherish { get; set; }

    public long? best { get; set; }

    public long? order1 { get; set; }

    public long? order2 { get; set; }

    public long? order3 { get; set; }

    public long? order4 { get; set; }

    public long? order5 { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ip { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wdate { get; set; }
}
