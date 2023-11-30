using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 관리자 제한 설정
/// </summary>
public partial class ADMIN_LIMIT_SETTING
{
    [Key]
    [StringLength(1)]
    [Unicode(false)]
    public string TYPE { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime END_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string USE_YN { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string AdminId { get; set; } = null!;

    [StringLength(50)]
    public string AdminName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Ip { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime MOD_DATE { get; set; }
}
