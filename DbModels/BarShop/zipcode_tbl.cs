using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("zipcode_tbl", Schema = "invtmng")]
public partial class zipcode_tbl
{
    [StringLength(50)]
    [Unicode(false)]
    public string zipcode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string seq { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string sido { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string gungu { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? dong { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ri { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? dosu { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? san { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ju_s { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ju_e { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ju_s1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ju_e1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? detail { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? detail_s { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? detail_e { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string juso { get; set; } = null!;
}
