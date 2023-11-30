using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class mcard_Invitation_log
{
    public int seq { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? memo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }
}
