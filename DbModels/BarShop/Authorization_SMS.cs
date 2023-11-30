using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SMS 인증 로그
/// </summary>
[Keyless]
public partial class Authorization_SMS
{
    public int SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GUID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? HPHONE { get; set; }

    public int? SMS_NUM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
