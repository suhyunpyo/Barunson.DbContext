using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 바로가기.즐겨찾기 참여
/// </summary>
public partial class S4_Event_install
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? favorite_install { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? desktop_install { get; set; }

    public int? favorite_cnt { get; set; }

    public int? desktop_cnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSelection { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isUsed { get; set; }
}
