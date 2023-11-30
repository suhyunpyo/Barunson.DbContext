using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_McardClickCount
{
    [Key]
    public int Seq { get; set; }

    public int? Company_Seq { get; set; }

    public int? OrderSeq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Gubun { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Ip { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }
}
