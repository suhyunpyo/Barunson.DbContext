using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class Sheet1_20200520
{
    public double? F1 { get; set; }

    public int? order_seq { get; set; }

    [StringLength(255)]
    public string? 주문자 { get; set; }

    [StringLength(50)]
    public string? ptitle { get; set; }

    public double? 인쇄수량 { get; set; }

    [StringLength(255)]
    public string? 담당자 { get; set; }

    [StringLength(255)]
    public string? 차수 { get; set; }

    [StringLength(255)]
    public string? 카드 { get; set; }
}
