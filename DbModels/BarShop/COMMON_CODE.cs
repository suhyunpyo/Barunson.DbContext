using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 코드 관리
/// </summary>
public partial class COMMON_CODE
{
    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string CMMN_CODE { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? LANG_CODE { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? CLSS_CODE { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? CLSS_NAME { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? DTL_CLSS { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DTL_NAME { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? DTL_DESC { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? RMRK_CLMN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DISPLAY_YORN { get; set; }

    public int? SORT_NUM { get; set; }

    [Precision(0)]
    public DateTime? REG_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? REG_ID { get; set; }

    [Precision(0)]
    public DateTime? MDF_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? MDF_ID { get; set; }
}
