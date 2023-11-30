using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// inipay 로그
/// </summary>
[Keyless]
public partial class inipay_vbank_log
{
    public int seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ID_MERCHANT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NO_TID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NO_OID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NO_VACCT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AMT_INPUT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NM_INPUTBANK { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NM_INPUT { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
