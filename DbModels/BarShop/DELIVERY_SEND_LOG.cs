using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 배송 로그
/// </summary>
public partial class DELIVERY_SEND_LOG
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ORDER_SEQ { get; set; }

    /// <summary>
    /// 주문테이블
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? ORDER_TABLE_NAME { get; set; }

    /// <summary>
    /// 송장번호
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? DELIVERY_CODE { get; set; }

    /// <summary>
    /// 결과코드
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? RESULT_CODE { get; set; }

    /// <summary>
    /// 결과메세지
    /// </summary>
    [StringLength(500)]
    public string? RESULT_MSG { get; set; }

    [StringLength(500)]
    public string? ERROR_MSG { get; set; }

    [StringLength(500)]
    public string? ERROR_DESC { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
