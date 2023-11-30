using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 한진택배 우편번호
/// </summary>
[Keyless]
public partial class HANJIN_ZIPCODE
{
    [StringLength(6)]
    [Unicode(false)]
    public string? ZIPCODE { get; set; }
}
