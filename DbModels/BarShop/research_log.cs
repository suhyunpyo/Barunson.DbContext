using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class research_log
{
    [Key]
    public int id { get; set; }

    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans2 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans3_1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans4 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans5 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans5_1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ans6 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ans6_str { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
