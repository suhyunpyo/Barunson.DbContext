using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class Tiara_ProdView
{
    public int CARD_SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CARD_CODE { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? CARD_Name { get; set; }

    public short? COMPANY { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? is100 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? is200 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? is300 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? issbaesong { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CARD_IMG_MS { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISHAVE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSelfEdit { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISSAMPLE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReInputDate { get; set; }

    public int? sales_ranking { get; set; }

    public short? bestRangking { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isTrendy { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isRomantic { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isTie { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isElegant { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isGold { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isStylish { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isRibon { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isButterFly { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isHeart { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isWinitial { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isPress { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isPearl { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isYu { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSweet { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isFlower { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isHologram { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? card_shape { get; set; }

    public int? cont_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BEST_YES_OR_NO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? NEW_YES_OR_NO { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string recomend_yes_or_no { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? online_yes_or_no { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string display_yes_or_no { get; set; } = null!;

    public int card_price_customer { get; set; }

    public double? disrate400 { get; set; }

    public int card_sale_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? regist_date { get; set; }
}
