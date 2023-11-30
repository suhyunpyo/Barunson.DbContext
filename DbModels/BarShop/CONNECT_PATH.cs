using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CONNECT_PATH
{
    public int idx { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? page { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? path { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? pass { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ip { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? os { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? browser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? wdate { get; set; }
}
