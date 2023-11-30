using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_eCardBest
{
    [Key]
    public int Order_Seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime RegDate { get; set; }
}
