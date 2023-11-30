using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// barunson_authinfo
/// </summary>
[Keyless]
public partial class barunson_authinfo
{
    [StringLength(255)]
    public string? uid { get; set; }

    [Column("이름-주민번호")]
    [StringLength(255)]
    public string? 이름_주민번호 { get; set; }

    [StringLength(255)]
    public string? dupinfo { get; set; }

    [StringLength(255)]
    public string? conninfo { get; set; }
}
