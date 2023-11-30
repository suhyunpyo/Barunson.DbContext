using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 빠른손-처리히스토리 내역
/// </summary>
[Index("order_seq", Name = "NCI_custom_order_history_order_seq", AllDescending = true)]
public partial class custom_order_history
{
    [Key]
    public int id { get; set; }

    /// <summary>
    /// 수정섹션
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? htype { get; set; }

    /// <summary>
    /// 주문번호
    /// </summary>
    public int order_seq { get; set; }

    /// <summary>
    /// 담당자
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? memo { get; set; }

    /// <summary>
    /// 관련 쿼리문
    /// </summary>
    [StringLength(2000)]
    [Unicode(false)]
    public string? system_sql { get; set; }

    /// <summary>
    /// 히스토리보기 여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isVisible { get; set; }

    /// <summary>
    /// 아이피정보
    /// </summary>
    [StringLength(60)]
    [Unicode(false)]
    public string? ipAddress { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
