using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_emBoard
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    public int Board_Seq { get; set; }

    public int Order_Seq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(4000)]
    public string? content { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? RegDate { get; set; }
}
