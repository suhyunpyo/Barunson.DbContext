using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_order_tax
{
    [Key]
    public int id { get; set; }

    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? upfile { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? msg { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
