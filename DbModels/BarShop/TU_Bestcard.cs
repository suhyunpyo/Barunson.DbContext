using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class TU_Bestcard
{
    [Key]
    public int seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int? company_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string content { get; set; } = null!;

    public int view_cnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string best_view { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string detail_view { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime rdate { get; set; }
}
