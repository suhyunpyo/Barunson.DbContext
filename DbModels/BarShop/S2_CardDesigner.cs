using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드디자이너 정보
/// </summary>
public partial class S2_CardDesigner
{
    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string designer_id { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string designer_name { get; set; } = null!;

    [StringLength(100)]
    public string? designer_img { get; set; }

    [StringLength(100)]
    public string? designer_title { get; set; }

    [StringLength(4000)]
    public string? designer_content { get; set; }

    [StringLength(30)]
    public string? designer_card_code1 { get; set; }

    [StringLength(30)]
    public string? designer_card_code2 { get; set; }

    [StringLength(30)]
    public string? designer_card_code3 { get; set; }

    [StringLength(30)]
    public string? designer_card_code4 { get; set; }
}
