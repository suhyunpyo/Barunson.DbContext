using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_POINT
{
    [Key]
    public int id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string member_id { get; set; } = null!;

    public int point { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? comment { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    public int? order_detail_id { get; set; }
}
