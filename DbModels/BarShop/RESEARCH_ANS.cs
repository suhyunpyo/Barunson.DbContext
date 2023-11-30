using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class RESEARCH_ANS
{
    public int id { get; set; }

    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isReceive { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans1_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans2_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans3_str { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans4_str { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? service_ment { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_Date { get; set; }
}
