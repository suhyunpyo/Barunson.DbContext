using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class The_Ewed_Best
{
    [Key]
    public int idx { get; set; }

    public int order_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string groom_name { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string bride_name { get; set; } = null!;

    public int productID { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string best_year { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string best_month { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string best_week { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? FileName { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime regdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sales_Gubun { get; set; }
}
