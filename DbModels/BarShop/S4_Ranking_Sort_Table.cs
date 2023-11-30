using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("RK_ST_SEQ", "RK_Card_Code", Name = "S4_Ranking_Sort_Table_ST_SEQ_Card_Code")]
public partial class S4_Ranking_Sort_Table
{
    [Key]
    public int RK_Idx { get; set; }

    public int? RK_ST_SEQ { get; set; }

    public int? RK_Card_Code { get; set; }

    [StringLength(100)]
    public string? RK_Title { get; set; }
}
