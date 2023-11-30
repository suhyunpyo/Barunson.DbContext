using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class temp_deardeer_member
{
    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string member_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string email { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string hphone { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string wedding_dt { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? emailYN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? hphoneYN { get; set; }
}
