using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class SAMPLE_LIKE_CHECK
{
    public int LIKE_SEQ { get; set; }

    public int LIKE_SAMPLE_ORDER_SEQ { get; set; }

    public int LIKE_CARD_SEQ { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string LIKE_UID { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string LIKE_IP { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime REG_DATE { get; set; }
}
