using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 샘플 배송비 관리
/// </summary>
[PrimaryKey("SALES_GUBUN", "ISMEMBER")]
public partial class SAMPLE_DELIVERY_PRICE_INFO
{
    /// <summary>
    /// 사이트구분
    /// </summary>
    [Key]
    [StringLength(2)]
    public string SALES_GUBUN { get; set; } = null!;

    /// <summary>
    /// 첫 주문 배송비
    /// </summary>
    public int FIRST_DELIVERY_PRICE { get; set; }

    /// <summary>
    /// 첫 주문 이후 배송비
    /// </summary>
    public int DELIVERY_PRICE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CREATED_TMSTMP { get; set; }

    [StringLength(50)]
    public string? CREATED_USERID { get; set; }

    [Key]
    [StringLength(1)]
    public string ISMEMBER { get; set; } = null!;
}
