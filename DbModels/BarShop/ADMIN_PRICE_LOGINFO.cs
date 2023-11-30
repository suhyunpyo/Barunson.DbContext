using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 관리자 상품가격변경 로그
/// </summary>
public partial class ADMIN_PRICE_LOGINFO
{
    [Key]
    public int Seq { get; set; }

    public int? CardSeq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AdminId { get; set; }

    [StringLength(50)]
    public string? AdminName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ip { get; set; }

    public int? PrePrice { get; set; }

    public int? AfterPrice { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }
}
