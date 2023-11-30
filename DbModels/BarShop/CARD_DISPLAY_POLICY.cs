using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CARD_DISPLAY_POLICY
{
    public int? DISPLAY_ORDER { get; set; }

    public int CARD_SEQ { get; set; }

    public int CATEGORY_SEQ { get; set; }

    [Key]
    public int ID { get; set; }

    [ForeignKey("CATEGORY_SEQ")]
    [InverseProperty("CARD_DISPLAY_POLICY")]
    public virtual DISPLAY_CATEGORY CATEGORY_SEQNavigation { get; set; } = null!;
}
