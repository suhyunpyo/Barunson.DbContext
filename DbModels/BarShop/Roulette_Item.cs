using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Roulette_Item
{
    [Key]
    public int roti_Idx { get; set; }

    [StringLength(50)]
    public string? roti_title { get; set; }

    public int roti_price { get; set; }

    [StringLength(50)]
    public string? roti_company_name { get; set; }

    [StringLength(1000)]
    public string? roti_memo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime roti_regdate { get; set; }

    public int roti_status { get; set; }

    /// <summary>
    /// 아이템종류(P:상품, C:쿠폰)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string roti_type { get; set; } = null!;

    /// <summary>
    /// 쿠폰번호
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? roti_couponCD { get; set; }

    /// <summary>
    /// 유효기간시작일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? roti_sdate { get; set; }

    /// <summary>
    /// 유효기간종료일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? roti_edate { get; set; }
}
