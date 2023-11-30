using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 송장코드 사용로그
/// </summary>
public partial class LT_DELCODE_USAGE_LOG
{
    [Key]
    public int SEQ { get; set; }

    public int? DELCODE_SEQ { get; set; }

    public long? CODESEQ { get; set; }

    /// <summary>
    /// 송장번호
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? DELIVERY_CODE_NUM { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SP_NAME { get; set; }

    /// <summary>
    /// 주문번호
    /// </summary>
    public int? ORDER_SEQ { get; set; }

    public int? DELIVERY_ID { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
