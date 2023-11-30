using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 답례품상세정보
/// </summary>
public partial class S2_CardDetailEtc
{
    [Key]
    public int card_seq { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string card_category { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isNew { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isBest { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isPlan { get; set; } = null!;

    [StringLength(50)]
    public string? composition { get; set; }

    [StringLength(3000)]
    public string? summary { get; set; }

    [StringLength(500)]
    public string? origin { get; set; }

    [StringLength(200)]
    public string? etc1 { get; set; }

    [StringLength(200)]
    public string? etc2 { get; set; }

    public int? min_onum { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? option_str1 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str3 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str4 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? option_str5 { get; set; }

    public int? card_sale_price { get; set; }

    [StringLength(4000)]
    public string? card_content { get; set; }

    public int? isDisplay { get; set; }

    public int? delivery_price { get; set; }

    [StringLength(500)]
    public string? brand_story { get; set; }

    [StringLength(4000)]
    public string? delivery_policy { get; set; }

    [StringLength(4000)]
    public string? refund_policy { get; set; }

    public int? free_delivery_price { get; set; }

    [Column(TypeName = "text")]
    public string? contents { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Delivery_Ty { get; set; }

    public byte? Delivery_Request_Dt { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Hover_Title { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Hover_Main_Title { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Hover_Sub_Title { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Main_Title { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Sub_Title { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Delivery_Price_Str { get; set; }

    [StringLength(100)]
    public string? Contents_Main_Copy { get; set; }

    [StringLength(100)]
    public string? Contents_Sub_Copy { get; set; }

    [StringLength(1000)]
    public string? Contents_Option_Name { get; set; }

    [StringLength(3000)]
    public string? Contents_Option_Summary { get; set; }

    [StringLength(100)]
    public string? QnA_Title { get; set; }

    [StringLength(1000)]
    public string? QnA_Info { get; set; }
}
