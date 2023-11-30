using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// old) TMAP
/// </summary>
public partial class custom_order_tmap
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string nick_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string wname { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string waddr { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string wdate { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string rstatus { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? cf_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? req_date { get; set; }
}
