using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_CPC_Statics
{
    [Key]
    public int S4_CPC_Idx { get; set; }

    public int? S4_CPC_Company { get; set; }

    [StringLength(50)]
    public string? S4_CPC_Banner_Title { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? S4_CPC_Regdate { get; set; }
}
