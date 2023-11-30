using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 고객 접근 디바이스 정보
/// </summary>
public partial class S2_USERINFO_SIGNUP_DEVICE
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string DUPINFO { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [StringLength(1000)]
    [Unicode(false)]
    public string? USER_AGENT { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? DEVICE_TYPE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
