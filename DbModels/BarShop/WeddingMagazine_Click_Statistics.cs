using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class WeddingMagazine_Click_Statistics
{
    [Key]
    public int seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Gubun { get; set; } = null!;

    public int? Click { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Reg_date { get; set; }

    public int? Board_num { get; set; }
}
