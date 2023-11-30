using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class POLLCONTENT
{
    public int? q_idx { get; set; }

    public int? a_idx { get; set; }

    [Column(TypeName = "text")]
    public string? content { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wdate { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ip { get; set; }
}
