using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class Yoosami
{
    public int Seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    public int? Visit { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Site { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Source { get; set; }
}
