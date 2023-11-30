using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class TB_PB_PRODUCT
{
    public int? IDX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CT_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_TYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_MAPSET { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? IMAGE_URL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_ORDBY { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MAKE_COMCODE { get; set; }
}
