using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class POLLCOUNT
{
    public int idx { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? id { get; set; }

    public int? q_idx { get; set; }

    public int? a_idx { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wdate { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ip { get; set; }
}
