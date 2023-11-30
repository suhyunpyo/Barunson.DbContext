using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class PHOTOBOOK_ADMIN_MENT
{
    public int id { get; set; }

    public int order_id { get; set; }

    public byte status { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string ment { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
