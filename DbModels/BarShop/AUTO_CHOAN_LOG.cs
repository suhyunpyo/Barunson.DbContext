using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 자동초안 로그
/// </summary>
[Index("ORDER_SEQ", Name = "NCI_Auto_choan_log_order_seq", AllDescending = true)]
public partial class AUTO_CHOAN_LOG
{
    [Key]
    public int SEQ { get; set; }

    /// <summary>
    /// 주문seq
    /// </summary>
    public int? ORDER_SEQ { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? LOCATION { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? SUB_LOCATION { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? MESSAGE { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? DESCRIPTION { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? REG_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? REG_IP { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? REG_DATE { get; set; }
}
