using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 나눔 가격
/// </summary>
[Keyless]
public partial class COMPANY_Nanum_Price
{
    public int nanum_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime last_update { get; set; }
}
