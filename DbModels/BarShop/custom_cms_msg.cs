using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_cms_msg
{
    [Key]
    public long id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_type { get; set; }

    public int? order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? cms_type { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string cphone { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string msg { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;
}
