using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class EVENT_MARKETING_AGREEMENT
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime created_tmstmp { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? gubun { get; set; }

    public int? sample_order_seq { get; set; }
}
