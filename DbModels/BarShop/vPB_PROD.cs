using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class vPB_PROD
{
    [StringLength(50)]
    [Unicode(false)]
    public string? OASIS_IDX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_NAME { get; set; }

    public int? TB_PRDT_IDX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CT_CODE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PRDT_TYPE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SIZE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PAGES { get; set; }

    public int? IDX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? COATING_YN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? COVER_NAME { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? makecom_code { get; set; }
}
