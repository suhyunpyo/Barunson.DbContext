using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class m_count
{
    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? day { get; set; }

    public int? a1 { get; set; }

    public int? a2 { get; set; }

    public int? a3 { get; set; }

    public int? a4 { get; set; }

    public int? b1 { get; set; }

    public int? b2 { get; set; }

    public int? b3 { get; set; }

    public int? b4 { get; set; }

    public int? c1 { get; set; }

    public int? c2 { get; set; }

    public int? c3 { get; set; }

    public int? c4 { get; set; }
}
