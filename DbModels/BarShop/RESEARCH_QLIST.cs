using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class RESEARCH_QLIST
{
    public int id { get; set; }

    public int? research_seq { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string qtitle { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? ans1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans3 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans4 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans5 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ans6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ans7 { get; set; }

    public int? ans_cnt { get; set; }

    public int? ans1_cnt { get; set; }

    public int? ans2_cnt { get; set; }

    public int? ans3_cnt { get; set; }

    public int? ans4_cnt { get; set; }

    public int? ans5_cnt { get; set; }

    public int? ans6_cnt { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ans7_cnt { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_Date { get; set; }

    /// <summary>
    /// 0:사용안함,1:사용함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? status { get; set; }
}
