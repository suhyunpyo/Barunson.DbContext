using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카카오 동영상 추천 이벤트
/// </summary>
[Keyless]
public partial class EVT_BHANDS_COUPLES_VOTE
{
    public int Idx { get; set; }

    public int CouplesIdx { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RegDate { get; set; }
}
