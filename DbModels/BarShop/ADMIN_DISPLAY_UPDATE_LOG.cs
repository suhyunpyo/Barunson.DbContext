using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 관리자 전시설정 변경 로그
/// </summary>
public partial class ADMIN_DISPLAY_UPDATE_LOG
{
    [Key]
    public int Seq { get; set; }

    public int Card_Seq { get; set; }

    public int Company_Seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string AdminId { get; set; } = null!;

    [StringLength(50)]
    public string AdminName { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Ip { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? PreIsDisplay { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AfterIsDisplay { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PreIsJumun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AfterIsJumun { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }
}
