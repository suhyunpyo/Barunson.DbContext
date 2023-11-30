using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 예전 프리미어페이퍼 이미지경로
/// </summary>
[Keyless]
public partial class S4_Premier_Business_Img
{
    public int? seq { get; set; }

    public int? sub_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? img_thumb { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? img_big { get; set; }

    public int? sorting_num { get; set; }

    [StringLength(200)]
    public string? card_text { get; set; }
}
