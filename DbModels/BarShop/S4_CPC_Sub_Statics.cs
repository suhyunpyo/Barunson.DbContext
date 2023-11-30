using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_CPC_Sub_Statics
{
    [Key]
    public long S4_CPC_Sub_Idx { get; set; }

    public int? S4_CPC_Sub_Code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime S4_CPC_Sub_Regdate { get; set; }
}
