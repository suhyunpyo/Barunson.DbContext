using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// Old 카드 카테고리
/// </summary>
public partial class CARD_CATEGORY
{
    [Key]
    public int CARD_CATEGORY_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CATEGORY_NAME { get; set; } = null!;

    public int CATEGORY_UPPER_CODE { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CATEGORY_DESCRIPTION { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? REGIST_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? LAST_UPDATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string CATEGORY_USED { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string SAMPLE_SUPPLY { get; set; } = null!;

    public int COUNT_IMG_DISPLAY { get; set; }

    public int MINIMUM_ORDER { get; set; }

    public int? DEPTH { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? PRODUCE_YEAR { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CATEGORY_DIV { get; set; }

    [InverseProperty("CARD_CATEGORY_SEQNavigation")]
    public virtual ICollection<DISCOUNT_POLICY> DISCOUNT_POLICY { get; } = new List<DISCOUNT_POLICY>();
}
