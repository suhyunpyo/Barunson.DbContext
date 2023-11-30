using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class RECENT_VIEW_CARD_MST
{
    [Key]
    public int RECENT_VIEW_CARD_MST_SEQ { get; set; }

    public int COMPANY_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string GUID { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
