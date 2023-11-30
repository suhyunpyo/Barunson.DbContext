using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class DISPLAY_CATEGORY
{
    [Key]
    public int CATEGORY_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CATEGORY_NAME { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string? CATEGORY_DESC { get; set; }

    public int? DISPLAY_COUNT { get; set; }

    public int? CATEGORY_DIV { get; set; }

    [InverseProperty("CATEGORY_SEQNavigation")]
    public virtual ICollection<CARD_DISPLAY_POLICY> CARD_DISPLAY_POLICY { get; } = new List<CARD_DISPLAY_POLICY>();

    [InverseProperty("CATEGORY_SEQNavigation")]
    public virtual ICollection<CUSTOM_CARD_DISPLAY_POLICY> CUSTOM_CARD_DISPLAY_POLICY { get; } = new List<CUSTOM_CARD_DISPLAY_POLICY>();
}
