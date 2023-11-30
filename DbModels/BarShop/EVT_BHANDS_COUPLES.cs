using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카카오 동영상 이벤트
/// </summary>
public partial class EVT_BHANDS_COUPLES
{
    [Key]
    public int seq { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string gubun { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? snsUrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? upMV_name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? is_display { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime created_tmstmp { get; set; }
}
