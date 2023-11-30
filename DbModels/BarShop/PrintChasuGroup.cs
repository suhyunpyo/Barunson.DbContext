using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class PrintChasuGroup
{
    public int Seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string GroupCode { get; set; } = null!;

    public short GroupCodeSeq { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string GroupName { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? GroupDesc { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? GroupRemark { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string GroupType { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string UseYN { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime RegDT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RegUser { get; set; } = null!;
}
