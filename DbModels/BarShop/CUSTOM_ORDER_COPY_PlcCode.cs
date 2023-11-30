using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 지시서 코드 관리
/// </summary>
public partial class CUSTOM_ORDER_COPY_PlcCode
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string plc_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? plc_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }
}
