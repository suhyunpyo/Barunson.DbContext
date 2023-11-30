using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class TB_PB_SKIN
{
    public int? IDX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SAMLE_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? THUMB_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? XML_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SIZE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CATEGORY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_TYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SKIN_MAPSET { get; set; }
}
