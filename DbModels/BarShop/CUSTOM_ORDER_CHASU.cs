using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 초대장 인쇄차수
/// </summary>
public partial class CUSTOM_ORDER_CHASU
{
    [Key]
    public long id { get; set; }

    /// <summary>
    /// 차수일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? pdate { get; set; }

    /// <summary>
    /// 차수
    /// </summary>
    public int? pseq { get; set; }

    /// <summary>
    /// 주문번호
    /// </summary>
    public int order_seq { get; set; }

    /// <summary>
    /// 한 차수내의 순서
    /// </summary>
    public int? oseq { get; set; }

    /// <summary>
    /// 원고검토일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? proc_date1 { get; set; }

    /// <summary>
    /// 원고검토마감일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? proc_date2 { get; set; }

    /// <summary>
    /// 차수지정일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? proc_date3 { get; set; }

    /// <summary>
    /// 코렐병합일
    /// </summary>
    [Column(TypeName = "smalldatetime")]
    public DateTime? proc_date4 { get; set; }

    /// <summary>
    /// 인쇄 예정일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? pdate_Real { get; set; }
}
