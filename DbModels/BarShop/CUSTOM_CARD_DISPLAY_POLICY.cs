using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("CATEGORY_SEQ", "CARD_SEQ")]
public partial class CUSTOM_CARD_DISPLAY_POLICY
{
    [Key]
    public int CARD_SEQ { get; set; }

    public int? DISPLAY_ORDER { get; set; }

    [Key]
    public int CATEGORY_SEQ { get; set; }

    [ForeignKey("CATEGORY_SEQ")]
    [InverseProperty("CUSTOM_CARD_DISPLAY_POLICY")]
    public virtual DISPLAY_CATEGORY CATEGORY_SEQNavigation { get; set; } = null!;
}
