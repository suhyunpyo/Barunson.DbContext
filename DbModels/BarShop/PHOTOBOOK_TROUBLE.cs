using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_TROUBLE
{
    [Key]
    public int order_id { get; set; }

    public int? up_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string trouble_type { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string? trouble_msg { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? upfile { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
