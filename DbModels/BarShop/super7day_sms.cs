using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class super7day_sms
{
    public int idx { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? uphone { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sendYN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime regdate { get; set; }
}
