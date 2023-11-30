using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CHOAN_OBJECT_COMMON_CODE
{
    public int OBJ_SEQ { get; set; }

    [StringLength(100)]
    public string? GROUP_NAME { get; set; }

    [StringLength(100)]
    public string? OBJ_CODE_NAME { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? OBJ_CODE { get; set; }

    [StringLength(4000)]
    public string? OBJ_DESC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
