using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class tMember_secede
{
    public int ms_idx { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string ms_uid { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? ms_reason { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ms_etc_reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ddate { get; set; }
}
