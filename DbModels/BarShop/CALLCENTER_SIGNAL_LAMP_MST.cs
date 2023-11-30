using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 콜선터 신호등
/// </summary>
public partial class CALLCENTER_SIGNAL_LAMP_MST
{
    [Key]
    public int SEQ { get; set; }

    public int? CALL_BUSY { get; set; }

    public int? CALL_GOOD { get; set; }

    public int? QNA_BUSY { get; set; }

    public int? QNA_GOOD { get; set; }

    public int? SMS_BUSY { get; set; }

    public int? SMS_GOOD { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
