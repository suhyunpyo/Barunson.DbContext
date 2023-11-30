using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class getOverture
{
    [StringLength(15)]
    [Unicode(false)]
    public string? userip { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? site { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }
}
