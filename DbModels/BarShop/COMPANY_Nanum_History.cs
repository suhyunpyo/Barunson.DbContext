using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 나눔 히스토리
/// </summary>
public partial class COMPANY_Nanum_History
{
    [Key]
    public int seq { get; set; }

    public int add_nanum_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
