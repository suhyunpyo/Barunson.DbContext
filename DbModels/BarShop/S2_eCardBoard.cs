using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_eCardBoard
{
    [Key]
    public int Board_Seq { get; set; }

    public int? Order_Seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column(TypeName = "text")]
    public string? Content { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Pwd { get; set; }
}
