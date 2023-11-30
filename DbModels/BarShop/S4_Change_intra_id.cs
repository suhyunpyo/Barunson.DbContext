using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S4_Change_intra_id
{
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string user_id { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string password { get; set; } = null!;
}
