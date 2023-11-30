using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_event_mailing
{
    [Key]
    public int seq { get; set; }

    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string umail { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? send { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? mdate { get; set; }
}
