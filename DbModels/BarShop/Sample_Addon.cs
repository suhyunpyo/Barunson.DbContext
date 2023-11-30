using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Sample_Addon
{
    [Key]
    public int Sample_Addon_Seq { get; set; }

    public int? Company_Seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Sales_Gubun { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Promotion_Year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Promotion_Month { get; set; }

    public int? Card_Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Card_Code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Use_YN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Reg_Date { get; set; }
}
